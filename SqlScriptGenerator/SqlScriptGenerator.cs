using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SqlScriptGenerator
{
    public partial class SqlScriptGenerator : Form
    {
        #region Constructor
        public SqlScriptGenerator()
        {
            InitializeComponent();
        }
        #endregion
        #region Desctructor
        ~SqlScriptGenerator()
        {
            if (_sqlConnection != null)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
            }
        }
        #endregion


        #region private variables
        private string _connectionString = string.Empty;
        private SqlConnection _sqlConnection;
        private DataTable _gridDataTable = new DataTable();
        //private const string FILTER_COLUMN_TYPE = "data_type NOT IN ('uniqueidentifier', 'timestamp', 'image')";
        #endregion

        #region string GetFilteredColumnString()
        private string GetFilteredColumnString()
        {
            if ( this.chk_IncludeGuidColumn.Checked )
                return "data_type NOT IN ('timestamp', 'image')";

            return "data_type NOT IN ('uniqueidentifier', 'timestamp', 'image')";
        } 
        #endregion


        #region Reload/Unload Events
        private void UnloadServerListEvent()
        {
            this.cbx_ServerList.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.cbx_ServerList_KeyDown);
            this.cbx_ServerList.SelectedIndexChanged -= new System.EventHandler(this.cbx_ServerList_SelectedIndexChanged);
        }
        private void ReloadServerListEvent()
        {
            this.cbx_ServerList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_ServerList_KeyDown);
            this.cbx_ServerList.SelectedIndexChanged += new System.EventHandler(this.cbx_ServerList_SelectedIndexChanged);
        }

        private void UnloadDatabaseListEvent()
        {
            this.cbx_DatabaseList.SelectedIndexChanged -= new System.EventHandler(this.cbx_DatabaseList_SelectedIndexChanged);
        }
        private void ReloadDatabaseListEvent()
        {
            this.cbx_DatabaseList.SelectedIndexChanged += new System.EventHandler(this.cbx_DatabaseList_SelectedIndexChanged);
        }
        #endregion

        #region string GetSelectedStringValueFromListControl(ComboBox comboBox, string displayMember)
        private string GetSelectedStringValueFromListControl(ComboBox comboBox, string displayMember)
        {
            string result = string.Empty;
            if (comboBox.SelectedItem != null)
            {
                result = ((DataRowView)comboBox.SelectedItem).Row[displayMember].ToString().Trim();
            }
            if (result == string.Empty)
            {
                result = comboBox.Text;
            }
            return result;
        } 
        #endregion

        #region SqlConnection GetLatestSqlConnection()
        public SqlConnection GetLatestSqlConnection(string dataBaseName)
        {
            if (!IsConnectionUpdate(dataBaseName) || _sqlConnection == null)
            {
                _connectionString = GetUpdatedConnectionString(dataBaseName);
                _sqlConnection = new SqlConnection(_connectionString);
                _sqlConnection.Open();
            }

            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            return _sqlConnection;
        } 
        #endregion

        #region bool IsConnectionUpdate()
        private bool IsConnectionUpdate(string dataBaseName)
        {
            string currenctSelectedConnection = GetUpdatedConnectionString(dataBaseName);
            if (string.Compare(_connectionString, currenctSelectedConnection) != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        } 
        #endregion

        #region string GetUpdatedConnectionString()
        private string GetUpdatedConnectionString(string dataBaseName)
        {
            string dataSource = string.Empty;
            if (cbx_ServerList.SelectedItem != null)
            {
                dataSource = GetSelectedStringValueFromListControl(cbx_ServerList, "ServerName");
            }
            if (dataSource == string.Empty)
            {
                dataSource = cbx_ServerList.Text.Trim();
            }
            string dataBase = dataBaseName;
            return SqlConnectionHelper.GetConnectionString(dataSource, dataBase, rbn_WindowsSecurity.Checked, txt_LoginName.Text, txt_Password.Text);
        } 
        #endregion

        #region void OnPageLoad(object sender, EventArgs e)
        private void OnPageLoad(object sender, EventArgs e)
        {
            try
            {
                dgv_Result.DataError += new DataGridViewDataErrorEventHandler(dgv_Result_DataError);
                txt_OutputFolder.Text = Environment.GetFolderPath(fbd_OutputFolder.RootFolder);

                UnloadServerListEvent();

                UpdateServerList();
                UpdateTextboxStatus();

                ReloadServerListEvent();

                SetGridEvent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        void dgv_Result_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void UpdateServerList()
        private void UpdateServerList()
        {
            DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            DataView view = new DataView(table, string.Empty, "ServerName", DataViewRowState.Added);

            cbx_ServerList.DataSource = view;
            cbx_ServerList.DisplayMember = "ServerName";
        } 
        #endregion

        #region void UpdateDatabaseList()
        private void UpdateDatabaseList()
        {
            DataTable table = GetLatestSqlConnection(string.Empty).GetSchema(SqlClientMetaDataCollectionNames.Databases);
            DataView tableView = table.DefaultView;
            tableView.Sort = "database_name";
            cbx_DatabaseList.DataSource = table;
            cbx_DatabaseList.DisplayMember = "database_name";
        }
        #endregion

        #region UpdateTableList()
        private void UpdateTableList()
        {
            DataTable table = GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()).GetSchema(SqlClientMetaDataCollectionNames.Tables, new string[] { null, null, null, "BASE TABLE" });

            string selectedText = GetSelectedStringValueFromListControl(cbx_TableList, "TABLE_NAME");

            DataView tableView = table.DefaultView;
            tableView.Sort = "TABLE_NAME";

            //cbx_TableList.DataSource = table;
            cbx_TableList.DataSource = tableView;
            cbx_TableList.DisplayMember = "TABLE_NAME";
            cbx_TableList.Text = selectedText;
        }
        private void ResetTableList()
        {
            cbx_TableList.DataSource = null;
            cbx_TableList.Text = string.Empty;
        } 
        #endregion

        #region UpdateViewList()
        private void UpdateViewList()
        {
            DataTable table = GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()).GetSchema(SqlClientMetaDataCollectionNames.Tables, new string[] { null, null, null, "VIEW" });

            string selectedText = GetSelectedStringValueFromListControl(cbx_ViewList, "TABLE_NAME");
            cbx_ViewList.DataSource = table;
            cbx_ViewList.DisplayMember = "TABLE_NAME";
            cbx_ViewList.Text = selectedText;
        }
        private void ResetViewList()
        {
            cbx_ViewList.DataSource = null;
            cbx_ViewList.Text = string.Empty;
        } 
        #endregion

        #region UpdateTextboxStatus
        private void rbn_WindowsSecurity_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextboxStatus();
        }
        private void rbn_SQLLogin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextboxStatus();
        }
        private void UpdateTextboxStatus()
        {
            txt_LoginName.Enabled = rbn_SQLLogin.Checked;
            txt_Password.Enabled = rbn_SQLLogin.Checked;
        } 
        #endregion


        #region void cbx_DatabaseList_Click(object sender, EventArgs e)
        private void cbx_DatabaseList_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name") == string.Empty)
                {
                    UpdateDatabaseList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void cbx_TableList_Click(object sender, EventArgs e)
        private void cbx_TableList_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedStringValueFromListControl(cbx_TableList, "TABLE_NAME").Trim() == string.Empty)
                {
                    UpdateTableList();
                    ResetViewList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void cbx_ViewList_Click(object sender, EventArgs e)
        private void cbx_ViewList_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateViewList();
                ResetTableList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void cbx_ServerList_SelectedIndexChanged(object sender, EventArgs e)
        private void cbx_ServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UnloadServerListEvent();
                UnloadDatabaseListEvent();

                UpdateServerListProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ReloadServerListEvent();
                ReloadDatabaseListEvent();
            }
        }
        #endregion

        #region void cbx_ServerList_KeyDown(object sender, KeyEventArgs e)
        private void cbx_ServerList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                UnloadServerListEvent();
                UnloadDatabaseListEvent();

                if (e.KeyCode != Keys.Enter)
                    return;

                UpdateServerListProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ReloadServerListEvent();
                ReloadDatabaseListEvent();
            }
        }
        #endregion

        #region void txt_LoginName_KeyDown(object sender, KeyEventArgs e)
        private void txt_LoginName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                UnloadServerListEvent();
                UnloadDatabaseListEvent();

                if (e.KeyCode != Keys.Enter)
                    return;

                UpdateServerListProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ReloadServerListEvent();
                ReloadDatabaseListEvent();
            }
        }
        #endregion

        #region void txt_Password_KeyDown(object sender, KeyEventArgs e)
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                UnloadServerListEvent();
                UnloadDatabaseListEvent();

                if (e.KeyCode != Keys.Enter)
                    return;

                UpdateServerListProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ReloadServerListEvent();
                ReloadDatabaseListEvent();
            }
        }
        #endregion

        #region void UpdateServerListProcess()
        private void UpdateServerListProcess()
        {
            if (GetSelectedStringValueFromListControl(cbx_ServerList, "ServerName") != string.Empty || cbx_ServerList.Text != string.Empty)
            {
                cbx_DatabaseList.DataSource = null;
                cbx_TableList.DataSource = null;

                cbx_DatabaseList.Text = string.Empty;
                cbx_TableList.Text = string.Empty;

                UpdateDatabaseList();
                RefreshMultipleTableSelection();
            }
        }
        #endregion

        #region void cbx_DatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        private void cbx_DatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedStringValueFromListControl(cbx_ServerList, "ServerName") != string.Empty && GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name") != string.Empty)
                {
                    UpdateTableList();
                    ResetViewList();

                    RefreshMultipleTableSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion




        //Single Table

        #region void UpdateScriptTextBox()
        private void UpdateScriptTextBox()
        {
            txt_SelectionScript.Text = GenerateScriptFromSelection();
        }
        #endregion
        
        #region string SelectedTableName()
        private string SelectedTableName()
        {
            if (cbx_TableList.Text.Trim() != string.Empty)
                return GetSelectedStringValueFromListControl(cbx_TableList, "TABLE_NAME").Trim();
            else //(cbx_ViewList.Text.Trim() != string.Empty)
                return GetSelectedStringValueFromListControl(cbx_ViewList, "TABLE_NAME").Trim();
        }
        #endregion
        #region string GenerateScriptFromSelection()
        private string GenerateScriptFromSelection()
        {
            string tableName = SelectedTableName();


            DataTable columnsTable = GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()).GetSchema(SqlClientMetaDataCollectionNames.Columns, new string[] { null, null, tableName });
            DataView columnsView = new DataView(columnsTable, this.GetFilteredColumnString(), "ordinal_position", DataViewRowState.Added);
            //dgv_Result.DataSource = columnsView;

            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            for (int cnt = 0; cnt < columnsView.Count; cnt++)
            {
                string columnName = columnsView[cnt].Row["column_name"].ToString().Trim();

                if (cnt != 0)
                    builder.Append(", ");

                builder.Append("[").Append(columnName).Append("]");
            }
            builder.Append(" FROM ").Append("[").Append(tableName).Append("]");

            return builder.ToString();
        }
        #endregion

        #region void btn_AutomateScript_Click(object sender, EventArgs e)
        private void btn_AutomateScript_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateScriptTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void btn_RunScript_Click(object sender, EventArgs e)
        private void btn_RunScript_Click(object sender, EventArgs e)
        {
            try
            {
                FillGridData();
                UIHelper.SetGridColumnWidth(dgv_Result);
                UpdateColumnList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void FillGridData()
        private void FillGridData()
        {
            DataTable resultTable = new DataTable();
            System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(txt_SelectionScript.Text, GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()));
            txt_RowCount.Text = adapter.Fill(resultTable).ToString();
            resultTable.TableName = SelectedTableName();

            RemoveGridEvent();
            dgv_Result.DataSource = null;
            _gridDataTable = resultTable;
            _gridDataTable.AcceptChanges();

            dgv_Result.DataSource = _gridDataTable;
            SetGridEvent();

        }
        #endregion

        #region void SetGridRowsColor()
        private void SetGridRowsColor()
        {
            foreach (System.Windows.Forms.DataGridViewRow row in dgv_Result.Rows)
            {
                if (row.DataBoundItem is DataRowView)
                {
                    if (((DataRowView)row.DataBoundItem).Row is DataRow)
                    {
                        DataRow dataRow = ((DataRowView)row.DataBoundItem).Row as DataRow;
                        if (dataRow.RowState == DataRowState.Modified)
                        {
                            row.DefaultCellStyle.BackColor = Color.Lavender;
                        }
                        else if (row.DefaultCellStyle.BackColor == Color.Lavender)
                        {
                            //row.DefaultCellStyle.BackColor == Color.sys
                        }
                    }
                }
            }
        }
        #endregion

        #region void UpdateColumnList()
        private void UpdateColumnList()
        {
            List<string> columnList = new List<string>();
            foreach (DataColumn column in _gridDataTable.Columns)
            {
                columnList.Add(column.ColumnName);
            }
            cbx_ColumnList.DataSource = columnList;
        }
        #endregion

        #region void btn_GenerateFromGrid_Click(object sender, EventArgs e)
        private void btn_GenerateFromGrid_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder scriptBuilder = new StringBuilder();
                scriptBuilder.Append("---------------------------------------Insertion Script to : [").Append(SelectedTableName()).Append("]---------------------------------------");
                scriptBuilder.Append(Environment.NewLine).Append(Environment.NewLine);
                scriptBuilder.Append(SqlHelper.GenerateInsertionSQLScriptFromDataTable(_gridDataTable));

                LogHelper.SaveStringAs(scriptBuilder.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void btn_Preview_Click(object sender, EventArgs e)
        private void btn_Preview_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder scriptBuilder = new StringBuilder();
                scriptBuilder.Append("---------------------------------------Insertion Script to : [").Append(SelectedTableName()).Append("]---------------------------------------");
                scriptBuilder.Append(Environment.NewLine).Append(Environment.NewLine);
                scriptBuilder.Append(SqlHelper.GenerateInsertionSQLScriptFromDataTable(_gridDataTable));

                TextBoxControl txtControl = new TextBoxControl();
                txtControl.SetText(scriptBuilder.ToString());
                txtControl.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void btn_ReplaceAll_Click(object sender, EventArgs e)
        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (AcceptChangesPrompt())
                {
                    //int affectedRows = SqlHelper.ReplaceValueByColumn(_gridDataTable, cbx_ColumnList.Text, txt_Find.Text, txt_Replace.Text);
                    int affectedRows = SqlScriptGenerator.ReplaceValueByColumnInDataGridView(dgv_Result, cbx_ColumnList.Text, txt_Find.Text, txt_Replace.Text);

                    UIHelper.SetGridColumnWidth(dgv_Result);
                    //SetGridRowsColor();

                    MessageBox.Show(affectedRows.ToString() + " of rows replaced.", "Replaced", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_Undo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void btn_ReOrdering_Click(object sender, EventArgs e)
        private void btn_ReOrdering_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ReOrderFrom.Text.Trim() == string.Empty)
                    return;

                if (AcceptChangesPrompt())
                {
                    int reOrderFromValue = int.Parse(txt_ReOrderFrom.Text);
                    int incrementValue = int.Parse(txt_IncrementValue.Text);

                    //SqlHelper.ReOrderValueByColumn(_gridDataTable, cbx_ColumnList.Text, reOrderFromValue, incrementValue);
                    SqlScriptGenerator.ReOrderValueByColumnInDataGridView(dgv_Result, cbx_ColumnList.Text, reOrderFromValue, incrementValue);

                    btn_Undo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void btn_Undo_Click(object sender, EventArgs e)
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveGridEvent();
                _gridDataTable.RejectChanges();
                _gridDataTable.AcceptChanges();
                btn_Undo.Enabled = false;
                SetGridEvent();
                //SetGridRowsColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region static int ReplaceValueByColumnInDataGridView(DataGridView grid, string columnName, string find, string replace)
        private static int ReplaceValueByColumnInDataGridView(DataGridView grid, string columnName, string find, string replace)
        {
            int count = 0;

            int columnIndex = grid.Columns[columnName].Index;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string originalValue = row.Cells[columnIndex].Value.ToString();
                if (originalValue.IndexOf(find) > -1)
                {
                    count++;
                    string replacedValue = originalValue.Replace(find, replace);
                    row.Cells[columnIndex].Value = replacedValue;
                }
            }
            return count;
        }
        #endregion

        #region static void ReOrderValueByColumnInDataGridView(DataGridView grid, string columnName, int reOrderFromValue, int incrementValue)
        private static void ReOrderValueByColumnInDataGridView(DataGridView grid, string columnName, int reOrderFromValue, int incrementValue)
        {
            int count = 0;
            int columnIndex = grid.Columns[columnName].Index;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                row.Cells[columnIndex].Value = reOrderFromValue + count;
                count += incrementValue;
            }
        }
        #endregion

        #region dgv_Result Events
        private void SetGridEvent()
        {
            dgv_Result.CellValueChanged += new DataGridViewCellEventHandler(dgv_Result_Changed);
            dgv_Result.RowsAdded += new DataGridViewRowsAddedEventHandler(dgv_Result_RowsAdded);
            dgv_Result.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dgv_Result_RowsRemoved);
        }
        private void RemoveGridEvent()
        {
            dgv_Result.CellValueChanged -= new DataGridViewCellEventHandler(dgv_Result_Changed);
            dgv_Result.RowsAdded -= new DataGridViewRowsAddedEventHandler(dgv_Result_RowsAdded);
            dgv_Result.RowsRemoved -= new DataGridViewRowsRemovedEventHandler(dgv_Result_RowsRemoved);
        }
        private void dgv_Result_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgv_Result_Changed(sender, null);
        }
        private void dgv_Result_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                btn_Undo.Enabled = true;
                dgv_Result.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lavender;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_Result_Changed(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_Undo.Enabled = true;
                if (e != null)
                {
                    dgv_Result[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Lavender;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region bool AcceptChangesPrompt()
        private bool AcceptChangesPrompt()
        {
            bool result = true;
            if (btn_Undo.Enabled == true)
            {
                string message = "Accept changes made before?";
                if (MessageBox.Show(message, "Accept changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                {
                    result = false;
                }
                else
                {
                    RemoveGridEvent();
                    _gridDataTable.AcceptChanges();
                    SetGridEvent();
                }
            }
            return result;
        }
        #endregion

        #region void txt_SelectionScript_KeyDown(object sender, KeyEventArgs e)
        private void txt_SelectionScript_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (e.KeyCode == Keys.A)
                        txt_SelectionScript.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion









        //Multiple Tables

        
        Hashtable _selectedMultiTable = new Hashtable();
        //This Hashtable Key:TableName, Value:DataTable of Selected Columns 

        #region void RefreshMultipleTableSelection()
        private void RefreshMultipleTableSelection()
        {
            dgv_SelectedColumns.DataSource = null;
            _selectedMultiTable.Clear();

            lbx_MultiSelectedTable.Items.Clear();
            lbx_MultiTableListing.Items.Clear();

            UpdateMultiTableListing();
        } 
        #endregion

        #region void ShowSelectedColumnData(string tableName)
        private void ShowSelectedColumnData(string tableName)
        {
            if (_selectedMultiTable.Contains(tableName))
            {
                ColumnsData.SelectedColumnsDataTable selectedColumnsTable = _selectedMultiTable[tableName] as ColumnsData.SelectedColumnsDataTable;
                dgv_SelectedColumns.DataSource = selectedColumnsTable;
                UIHelper.SetGridColumnWidth(dgv_SelectedColumns);
            }
        } 
        #endregion


        #region UpdateMultiTableListing()
        private void UpdateMultiTableListing()
        {

            DataTable table = GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()).GetSchema(SqlClientMetaDataCollectionNames.Tables, new string[] { null, null, null, "BASE TABLE" });
            foreach (DataRow row in table.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString().Trim();

                lbx_MultiTableListing.Items.Add(tableName);
            }

          
        }
        #endregion


        #region void AddTableToSelectedList(string tableName)
        private void AddTableToSelectedList(string tableName)
        {
            if (!_selectedMultiTable.Contains(tableName))
            {
                DataTable columnsTable = GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()).GetSchema(SqlClientMetaDataCollectionNames.Columns, new string[] { null, null, tableName });
                DataView columnsView = new DataView(columnsTable, this.GetFilteredColumnString(), "ordinal_position", DataViewRowState.Added);

                ColumnsData.SelectedColumnsDataTable selectedColumns = new ColumnsData.SelectedColumnsDataTable();
                for (int cnt = 0; cnt < columnsView.Count; cnt++)
                {
                    ColumnsData.SelectedColumnsRow newRow = selectedColumns.NewSelectedColumnsRow();
                    newRow.ColumnName = columnsView[cnt].Row["column_name"].ToString().Trim();
                    newRow.Selected = true;
                    selectedColumns.AddSelectedColumnsRow(newRow);
                }
                _selectedMultiTable.Add(tableName, selectedColumns);

                lbx_MultiTableListing.Items.Remove(tableName);
                lbx_MultiSelectedTable.Items.Add(tableName);
                
            }
        }
        #endregion

        #region void RemoveTableFromSelectedList(string tableName)
        private void RemoveTableFromSelectedList(string tableName)
        {
            if (_selectedMultiTable.Contains(tableName))
            {
                _selectedMultiTable.Remove(tableName);

                lbx_MultiSelectedTable.Items.Remove(tableName);
                lbx_MultiTableListing.Items.Add(tableName);

            }
        } 
        #endregion

        #region void ProcessMultipleTablesGeneration()
        private void ProcessMultipleTablesGeneration()
        {
            string folderPath = txt_OutputFolder.Text;
            string fileNamePart = string.Empty;
            for (int cnt = 0; cnt < lbx_MultiSelectedTable.Items.Count; cnt++)
            {
                string tableName = lbx_MultiSelectedTable.Items[cnt].ToString().Trim();

                fileNamePart = "Insert_" + tableName + ".sql";

                string filePath = System.IO.Path.Combine(folderPath, fileNamePart);

                StringBuilder scriptBuilder = new StringBuilder();
                scriptBuilder.Append("---------------------------------------Insertion Script to : [").Append(tableName).Append("]---------------------------------------");
                scriptBuilder.Append(Environment.NewLine).Append(Environment.NewLine);
                scriptBuilder.Append(GenerateScriptByTableName(tableName));

                LogHelper.SaveStringToLocation(scriptBuilder.ToString(), filePath);
            }
        } 
        #endregion


        #region string GenerateScriptByTableName(string tableName)
        private string GenerateScriptByTableName(string tableName)
        {
            string insertionScriptFromTable = string.Empty;

            ArrayList selectedColumnsList = new ArrayList();
            ColumnsData.SelectedColumnsDataTable columnsTable = _selectedMultiTable[tableName] as ColumnsData.SelectedColumnsDataTable;
            foreach (ColumnsData.SelectedColumnsRow row in columnsTable.Rows)
            {
                if (row.Selected == true)
                {
                    selectedColumnsList.Add(row.ColumnName);
                }
            }
            string selectCommanText = SqlHelper.GenerateSelectionSQLScript(tableName, selectedColumnsList);

            DataTable resultTable = new DataTable();
            using (resultTable)
            {
                System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter(selectCommanText, GetLatestSqlConnection(GetSelectedStringValueFromListControl(cbx_DatabaseList, "database_name").Trim()));
                txt_RowCount.Text = adapter.Fill(resultTable).ToString();
                resultTable.TableName = tableName;

                insertionScriptFromTable = SqlHelper.GenerateInsertionSQLScriptFromDataTable(tableName, resultTable, selectedColumnsList);
            }
            return insertionScriptFromTable;
        } 
        #endregion


        #region void btn_AddTable_Click(object sender, EventArgs e)
        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbx_MultiTableListing.SelectedItems != null)
                {
                    List<string> selectedTableNameList = new List<string>(lbx_MultiTableListing.SelectedItems.Count);
                    for (int cnt = 0; cnt < lbx_MultiTableListing.SelectedItems.Count; cnt++)
                    {
                        selectedTableNameList.Add(lbx_MultiTableListing.SelectedItems[cnt].ToString());
                    }
                    foreach(string selectedTableName in selectedTableNameList)
                    {
                        AddTableToSelectedList(selectedTableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion


        #region void btn_RemoveTable_Click(object sender, EventArgs e)
        private void btn_RemoveTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbx_MultiSelectedTable.SelectedItems != null)
                {
                    List<string> selectedTableNameList = new List<string>(lbx_MultiSelectedTable.SelectedItems.Count);
                    for (int cnt = 0; cnt < lbx_MultiSelectedTable.SelectedItems.Count; cnt++)
                    {
                        selectedTableNameList.Add(lbx_MultiSelectedTable.SelectedItems[cnt].ToString());
                    }
                    foreach (string selectedTableName in selectedTableNameList)
                    {
                        RemoveTableFromSelectedList(selectedTableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void lbx_MultiSelectedTable_SelectedIndexChanged(object sender, EventArgs e)
        private void lbx_MultiSelectedTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListBox listBox = sender as ListBox;
                if (listBox.SelectedItems.Count == 1)
                {
                    string clickedTableName = listBox.SelectedItems[0].ToString();
                    ShowSelectedColumnData(clickedTableName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region void btn_GenerateMultiTables_Click(object sender, EventArgs e)
        private void btn_GenerateMultiTables_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessMultipleTablesGeneration();
                System.Diagnostics.Process.Start(txt_OutputFolder.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void btn_OutputFolder_Click(object sender, EventArgs e)
        private void btn_OutputFolder_Click(object sender, EventArgs e)
        {
            try
            {
                fbd_OutputFolder.SelectedPath = txt_OutputFolder.Text;
                if (fbd_OutputFolder.ShowDialog(this) == DialogResult.OK)
                {
                    txt_OutputFolder.Text = fbd_OutputFolder.SelectedPath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region void mnu_Exit_Click(object sender, EventArgs e)
        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Close();
            }
        } 
        #endregion


        #region void mnu_About_Click(object sender, EventArgs e)
        private void mnu_About_Click(object sender, EventArgs e)
        {
            SqlScriptGeneratorAboutBox aboutBox = new SqlScriptGeneratorAboutBox();
            aboutBox.Show(this);
        } 
        #endregion

        #region void btn_PreviewMultipleTable_Click(object sender, EventArgs e)
        private void btn_PreviewMultipleTable_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder scriptBuilder = new StringBuilder();
                for (int cnt = 0; cnt < lbx_MultiSelectedTable.Items.Count; cnt++)
                {
                    string tableName = lbx_MultiSelectedTable.Items[cnt].ToString().Trim();

                    scriptBuilder.Append("---------------------------------------Insertion Script to : [").Append(tableName).Append("]---------------------------------------");
                    scriptBuilder.Append(Environment.NewLine).Append(Environment.NewLine);

                    scriptBuilder.Append(GenerateScriptByTableName(tableName));
                    scriptBuilder.Append(Environment.NewLine).Append(Environment.NewLine);
                }

                TextBoxControl txtControl = new TextBoxControl();
                txtControl.SetText(scriptBuilder.ToString());
                txtControl.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion






    }

}