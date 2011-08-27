namespace SqlScriptGenerator
{
    partial class SqlScriptGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlScriptGenerator));
            this.cbx_ServerList = new System.Windows.Forms.ComboBox();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.rbn_WindowsSecurity = new System.Windows.Forms.RadioButton();
            this.rbn_SQLLogin = new System.Windows.Forms.RadioButton();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_DatabaseList = new System.Windows.Forms.ComboBox();
            this.cbx_TableList = new System.Windows.Forms.ComboBox();
            this.cbx_ViewList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbx_DataCollection = new System.Windows.Forms.GroupBox();
            this.pnl_GridMiddle = new System.Windows.Forms.Panel();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_ReOrdering = new System.Windows.Forms.Button();
            this.txt_IncrementValue = new System.Windows.Forms.TextBox();
            this.txt_ReOrderFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_ColumnList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.txt_Replace = new System.Windows.Forms.TextBox();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_RowCount = new System.Windows.Forms.TextBox();
            this.btn_GenerateFromGrid = new System.Windows.Forms.Button();
            this.pnl_GridUpper = new System.Windows.Forms.Panel();
            this.txt_SelectionScript = new System.Windows.Forms.TextBox();
            this.pnl_GridTopRight = new System.Windows.Forms.Panel();
            this.chk_IncludeGuidColumn = new System.Windows.Forms.CheckBox();
            this.btn_AutomateScript = new System.Windows.Forms.Button();
            this.btn_RunScript = new System.Windows.Forms.Button();
            this.pnl_ServerSelection = new System.Windows.Forms.Panel();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tab_SingleTable = new System.Windows.Forms.TabPage();
            this.tab_MultiTable = new System.Windows.Forms.TabPage();
            this.gbx_MultipleTables = new System.Windows.Forms.GroupBox();
            this.pnl_MultiTableMain = new System.Windows.Forms.Panel();
            this.pnl_MultiSelectedColumns = new System.Windows.Forms.Panel();
            this.dgv_SelectedColumns = new System.Windows.Forms.DataGridView();
            this.pnl_MultiSelectedTables = new System.Windows.Forms.Panel();
            this.lbx_MultiSelectedTable = new System.Windows.Forms.ListBox();
            this.pnl_MultiTableAddRemovePanel = new System.Windows.Forms.Panel();
            this.btn_AddTable = new System.Windows.Forms.Button();
            this.btn_RemoveTable = new System.Windows.Forms.Button();
            this.pnl_MultiTableListing = new System.Windows.Forms.Panel();
            this.lbx_MultiTableListing = new System.Windows.Forms.ListBox();
            this.pnl_MultipleBottom = new System.Windows.Forms.Panel();
            this.btn_PreviewMultipleTable = new System.Windows.Forms.Button();
            this.btn_OutputFolder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_OutputFolder = new System.Windows.Forms.TextBox();
            this.btn_GenerateMultiTables = new System.Windows.Forms.Button();
            this.fbd_OutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            ( (System.ComponentModel.ISupportInitialize)( this.dgv_Result ) ).BeginInit();
            this.gbx_DataCollection.SuspendLayout();
            this.pnl_GridMiddle.SuspendLayout();
            this.pnl_GridUpper.SuspendLayout();
            this.pnl_GridTopRight.SuspendLayout();
            this.pnl_ServerSelection.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.tab_SingleTable.SuspendLayout();
            this.tab_MultiTable.SuspendLayout();
            this.gbx_MultipleTables.SuspendLayout();
            this.pnl_MultiTableMain.SuspendLayout();
            this.pnl_MultiSelectedColumns.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dgv_SelectedColumns ) ).BeginInit();
            this.pnl_MultiSelectedTables.SuspendLayout();
            this.pnl_MultiTableAddRemovePanel.SuspendLayout();
            this.pnl_MultiTableListing.SuspendLayout();
            this.pnl_MultipleBottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_ServerList
            // 
            this.cbx_ServerList.FormattingEnabled = true;
            this.cbx_ServerList.Location = new System.Drawing.Point(92, 11);
            this.cbx_ServerList.Name = "cbx_ServerList";
            this.cbx_ServerList.Size = new System.Drawing.Size(277, 21);
            this.cbx_ServerList.TabIndex = 0;
            this.cbx_ServerList.SelectedIndexChanged += new System.EventHandler(this.cbx_ServerList_SelectedIndexChanged);
            this.cbx_ServerList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_ServerList_KeyDown);
            // 
            // dgv_Result
            // 
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Result.Location = new System.Drawing.Point(3, 222);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.Size = new System.Drawing.Size(896, 283);
            this.dgv_Result.TabIndex = 1;
            // 
            // rbn_WindowsSecurity
            // 
            this.rbn_WindowsSecurity.AutoSize = true;
            this.rbn_WindowsSecurity.Checked = true;
            this.rbn_WindowsSecurity.Location = new System.Drawing.Point(417, 15);
            this.rbn_WindowsSecurity.Name = "rbn_WindowsSecurity";
            this.rbn_WindowsSecurity.Size = new System.Drawing.Size(179, 17);
            this.rbn_WindowsSecurity.TabIndex = 2;
            this.rbn_WindowsSecurity.TabStop = true;
            this.rbn_WindowsSecurity.Text = "Windows NT Integrated Security";
            this.rbn_WindowsSecurity.UseVisualStyleBackColor = true;
            this.rbn_WindowsSecurity.CheckedChanged += new System.EventHandler(this.rbn_WindowsSecurity_CheckedChanged);
            // 
            // rbn_SQLLogin
            // 
            this.rbn_SQLLogin.AutoSize = true;
            this.rbn_SQLLogin.Location = new System.Drawing.Point(417, 41);
            this.rbn_SQLLogin.Name = "rbn_SQLLogin";
            this.rbn_SQLLogin.Size = new System.Drawing.Size(109, 17);
            this.rbn_SQLLogin.TabIndex = 3;
            this.rbn_SQLLogin.Text = "SQL Server Login";
            this.rbn_SQLLogin.UseVisualStyleBackColor = true;
            this.rbn_SQLLogin.CheckedChanged += new System.EventHandler(this.rbn_SQLLogin_CheckedChanged);
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(506, 64);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(218, 20);
            this.txt_LoginName.TabIndex = 4;
            this.txt_LoginName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LoginName_KeyDown);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(506, 90);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(218, 20);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password: ";
            // 
            // cbx_DatabaseList
            // 
            this.cbx_DatabaseList.FormattingEnabled = true;
            this.cbx_DatabaseList.Location = new System.Drawing.Point(92, 37);
            this.cbx_DatabaseList.Name = "cbx_DatabaseList";
            this.cbx_DatabaseList.Size = new System.Drawing.Size(277, 21);
            this.cbx_DatabaseList.TabIndex = 8;
            this.cbx_DatabaseList.SelectedIndexChanged += new System.EventHandler(this.cbx_DatabaseList_SelectedIndexChanged);
            this.cbx_DatabaseList.Click += new System.EventHandler(this.cbx_DatabaseList_Click);
            // 
            // cbx_TableList
            // 
            this.cbx_TableList.FormattingEnabled = true;
            this.cbx_TableList.Location = new System.Drawing.Point(92, 64);
            this.cbx_TableList.Name = "cbx_TableList";
            this.cbx_TableList.Size = new System.Drawing.Size(277, 21);
            this.cbx_TableList.TabIndex = 9;
            this.cbx_TableList.Click += new System.EventHandler(this.cbx_TableList_Click);
            // 
            // cbx_ViewList
            // 
            this.cbx_ViewList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ViewList.FormattingEnabled = true;
            this.cbx_ViewList.Location = new System.Drawing.Point(92, 91);
            this.cbx_ViewList.Name = "cbx_ViewList";
            this.cbx_ViewList.Size = new System.Drawing.Size(277, 21);
            this.cbx_ViewList.TabIndex = 10;
            this.cbx_ViewList.Visible = false;
            this.cbx_ViewList.Click += new System.EventHandler(this.cbx_ViewList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Source: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Database: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tables: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Views: ";
            this.label6.Visible = false;
            // 
            // gbx_DataCollection
            // 
            this.gbx_DataCollection.Controls.Add(this.dgv_Result);
            this.gbx_DataCollection.Controls.Add(this.pnl_GridMiddle);
            this.gbx_DataCollection.Controls.Add(this.pnl_GridUpper);
            this.gbx_DataCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_DataCollection.Location = new System.Drawing.Point(3, 3);
            this.gbx_DataCollection.Name = "gbx_DataCollection";
            this.gbx_DataCollection.Size = new System.Drawing.Size(902, 508);
            this.gbx_DataCollection.TabIndex = 15;
            this.gbx_DataCollection.TabStop = false;
            // 
            // pnl_GridMiddle
            // 
            this.pnl_GridMiddle.Controls.Add(this.btn_Undo);
            this.pnl_GridMiddle.Controls.Add(this.btn_Preview);
            this.pnl_GridMiddle.Controls.Add(this.label11);
            this.pnl_GridMiddle.Controls.Add(this.label12);
            this.pnl_GridMiddle.Controls.Add(this.btn_ReOrdering);
            this.pnl_GridMiddle.Controls.Add(this.txt_IncrementValue);
            this.pnl_GridMiddle.Controls.Add(this.txt_ReOrderFrom);
            this.pnl_GridMiddle.Controls.Add(this.label10);
            this.pnl_GridMiddle.Controls.Add(this.cbx_ColumnList);
            this.pnl_GridMiddle.Controls.Add(this.label9);
            this.pnl_GridMiddle.Controls.Add(this.label8);
            this.pnl_GridMiddle.Controls.Add(this.btn_ReplaceAll);
            this.pnl_GridMiddle.Controls.Add(this.txt_Replace);
            this.pnl_GridMiddle.Controls.Add(this.txt_Find);
            this.pnl_GridMiddle.Controls.Add(this.label7);
            this.pnl_GridMiddle.Controls.Add(this.txt_RowCount);
            this.pnl_GridMiddle.Controls.Add(this.btn_GenerateFromGrid);
            this.pnl_GridMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_GridMiddle.Location = new System.Drawing.Point(3, 96);
            this.pnl_GridMiddle.Name = "pnl_GridMiddle";
            this.pnl_GridMiddle.Size = new System.Drawing.Size(896, 126);
            this.pnl_GridMiddle.TabIndex = 2;
            // 
            // btn_Undo
            // 
            this.btn_Undo.Enabled = false;
            this.btn_Undo.Location = new System.Drawing.Point(407, 10);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(79, 23);
            this.btn_Undo.TabIndex = 29;
            this.btn_Undo.Text = "&Undo";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_Preview.Location = new System.Drawing.Point(707, 92);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(88, 23);
            this.btn_Preview.TabIndex = 28;
            this.btn_Preview.Text = "&Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Increment: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "From: ";
            // 
            // btn_ReOrdering
            // 
            this.btn_ReOrdering.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.btn_ReOrdering.Location = new System.Drawing.Point(98, 92);
            this.btn_ReOrdering.Name = "btn_ReOrdering";
            this.btn_ReOrdering.Size = new System.Drawing.Size(79, 23);
            this.btn_ReOrdering.TabIndex = 25;
            this.btn_ReOrdering.Text = "Re-&Ordering";
            this.btn_ReOrdering.UseVisualStyleBackColor = true;
            this.btn_ReOrdering.Click += new System.EventHandler(this.btn_ReOrdering_Click);
            // 
            // txt_IncrementValue
            // 
            this.txt_IncrementValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IncrementValue.Location = new System.Drawing.Point(88, 66);
            this.txt_IncrementValue.Name = "txt_IncrementValue";
            this.txt_IncrementValue.Size = new System.Drawing.Size(89, 20);
            this.txt_IncrementValue.TabIndex = 24;
            this.txt_IncrementValue.Text = "1";
            // 
            // txt_ReOrderFrom
            // 
            this.txt_ReOrderFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReOrderFrom.Location = new System.Drawing.Point(88, 40);
            this.txt_ReOrderFrom.Name = "txt_ReOrderFrom";
            this.txt_ReOrderFrom.Size = new System.Drawing.Size(89, 20);
            this.txt_ReOrderFrom.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Columns";
            // 
            // cbx_ColumnList
            // 
            this.cbx_ColumnList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ColumnList.FormattingEnabled = true;
            this.cbx_ColumnList.Location = new System.Drawing.Point(88, 10);
            this.cbx_ColumnList.Name = "cbx_ColumnList";
            this.cbx_ColumnList.Size = new System.Drawing.Size(277, 21);
            this.cbx_ColumnList.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Replace: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Find: ";
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_ReplaceAll.Location = new System.Drawing.Point(601, 92);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(88, 23);
            this.btn_ReplaceAll.TabIndex = 18;
            this.btn_ReplaceAll.Text = "&Replace All";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += new System.EventHandler(this.btn_ReplaceAll_Click);
            // 
            // txt_Replace
            // 
            this.txt_Replace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Replace.Location = new System.Drawing.Point(260, 65);
            this.txt_Replace.Name = "txt_Replace";
            this.txt_Replace.Size = new System.Drawing.Size(472, 20);
            this.txt_Replace.TabIndex = 14;
            // 
            // txt_Find
            // 
            this.txt_Find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Find.Location = new System.Drawing.Point(260, 39);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(472, 20);
            this.txt_Find.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(738, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Row Count: ";
            // 
            // txt_RowCount
            // 
            this.txt_RowCount.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txt_RowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RowCount.Enabled = false;
            this.txt_RowCount.Location = new System.Drawing.Point(805, 65);
            this.txt_RowCount.Name = "txt_RowCount";
            this.txt_RowCount.Size = new System.Drawing.Size(86, 20);
            this.txt_RowCount.TabIndex = 2;
            // 
            // btn_GenerateFromGrid
            // 
            this.btn_GenerateFromGrid.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_GenerateFromGrid.Location = new System.Drawing.Point(803, 92);
            this.btn_GenerateFromGrid.Name = "btn_GenerateFromGrid";
            this.btn_GenerateFromGrid.Size = new System.Drawing.Size(88, 23);
            this.btn_GenerateFromGrid.TabIndex = 0;
            this.btn_GenerateFromGrid.Text = "&Generate";
            this.btn_GenerateFromGrid.UseVisualStyleBackColor = true;
            this.btn_GenerateFromGrid.Click += new System.EventHandler(this.btn_GenerateFromGrid_Click);
            // 
            // pnl_GridUpper
            // 
            this.pnl_GridUpper.Controls.Add(this.txt_SelectionScript);
            this.pnl_GridUpper.Controls.Add(this.pnl_GridTopRight);
            this.pnl_GridUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_GridUpper.Location = new System.Drawing.Point(3, 16);
            this.pnl_GridUpper.Name = "pnl_GridUpper";
            this.pnl_GridUpper.Size = new System.Drawing.Size(896, 80);
            this.pnl_GridUpper.TabIndex = 3;
            // 
            // txt_SelectionScript
            // 
            this.txt_SelectionScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SelectionScript.Location = new System.Drawing.Point(0, 0);
            this.txt_SelectionScript.Multiline = true;
            this.txt_SelectionScript.Name = "txt_SelectionScript";
            this.txt_SelectionScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_SelectionScript.Size = new System.Drawing.Size(795, 80);
            this.txt_SelectionScript.TabIndex = 0;
            this.txt_SelectionScript.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SelectionScript_KeyDown);
            // 
            // pnl_GridTopRight
            // 
            this.pnl_GridTopRight.Controls.Add(this.chk_IncludeGuidColumn);
            this.pnl_GridTopRight.Controls.Add(this.btn_AutomateScript);
            this.pnl_GridTopRight.Controls.Add(this.btn_RunScript);
            this.pnl_GridTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_GridTopRight.Location = new System.Drawing.Point(795, 0);
            this.pnl_GridTopRight.Name = "pnl_GridTopRight";
            this.pnl_GridTopRight.Size = new System.Drawing.Size(101, 80);
            this.pnl_GridTopRight.TabIndex = 16;
            // 
            // chk_IncludeGuidColumn
            // 
            this.chk_IncludeGuidColumn.AutoSize = true;
            this.chk_IncludeGuidColumn.Checked = true;
            this.chk_IncludeGuidColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IncludeGuidColumn.Location = new System.Drawing.Point(10, 30);
            this.chk_IncludeGuidColumn.Name = "chk_IncludeGuidColumn";
            this.chk_IncludeGuidColumn.Size = new System.Drawing.Size(86, 17);
            this.chk_IncludeGuidColumn.TabIndex = 16;
            this.chk_IncludeGuidColumn.Text = "Include Guid";
            this.chk_IncludeGuidColumn.UseVisualStyleBackColor = true;
            // 
            // btn_AutomateScript
            // 
            this.btn_AutomateScript.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_AutomateScript.Location = new System.Drawing.Point(10, 5);
            this.btn_AutomateScript.Name = "btn_AutomateScript";
            this.btn_AutomateScript.Size = new System.Drawing.Size(88, 23);
            this.btn_AutomateScript.TabIndex = 15;
            this.btn_AutomateScript.Text = "Select Script";
            this.btn_AutomateScript.UseVisualStyleBackColor = true;
            this.btn_AutomateScript.Click += new System.EventHandler(this.btn_AutomateScript_Click);
            // 
            // btn_RunScript
            // 
            this.btn_RunScript.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_RunScript.Location = new System.Drawing.Point(10, 50);
            this.btn_RunScript.Name = "btn_RunScript";
            this.btn_RunScript.Size = new System.Drawing.Size(88, 23);
            this.btn_RunScript.TabIndex = 1;
            this.btn_RunScript.Text = "E&xecute";
            this.btn_RunScript.UseVisualStyleBackColor = true;
            this.btn_RunScript.Click += new System.EventHandler(this.btn_RunScript_Click);
            // 
            // pnl_ServerSelection
            // 
            this.pnl_ServerSelection.Controls.Add(this.label3);
            this.pnl_ServerSelection.Controls.Add(this.cbx_ServerList);
            this.pnl_ServerSelection.Controls.Add(this.label6);
            this.pnl_ServerSelection.Controls.Add(this.rbn_WindowsSecurity);
            this.pnl_ServerSelection.Controls.Add(this.label5);
            this.pnl_ServerSelection.Controls.Add(this.rbn_SQLLogin);
            this.pnl_ServerSelection.Controls.Add(this.label4);
            this.pnl_ServerSelection.Controls.Add(this.txt_LoginName);
            this.pnl_ServerSelection.Controls.Add(this.txt_Password);
            this.pnl_ServerSelection.Controls.Add(this.cbx_ViewList);
            this.pnl_ServerSelection.Controls.Add(this.label1);
            this.pnl_ServerSelection.Controls.Add(this.cbx_TableList);
            this.pnl_ServerSelection.Controls.Add(this.label2);
            this.pnl_ServerSelection.Controls.Add(this.cbx_DatabaseList);
            this.pnl_ServerSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ServerSelection.Location = new System.Drawing.Point(0, 24);
            this.pnl_ServerSelection.Name = "pnl_ServerSelection";
            this.pnl_ServerSelection.Size = new System.Drawing.Size(916, 120);
            this.pnl_ServerSelection.TabIndex = 16;
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tab_SingleTable);
            this.tab_Main.Controls.Add(this.tab_MultiTable);
            this.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Main.Location = new System.Drawing.Point(0, 144);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(916, 540);
            this.tab_Main.TabIndex = 17;
            // 
            // tab_SingleTable
            // 
            this.tab_SingleTable.Controls.Add(this.gbx_DataCollection);
            this.tab_SingleTable.Location = new System.Drawing.Point(4, 22);
            this.tab_SingleTable.Name = "tab_SingleTable";
            this.tab_SingleTable.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SingleTable.Size = new System.Drawing.Size(908, 514);
            this.tab_SingleTable.TabIndex = 0;
            this.tab_SingleTable.Text = "Single Table";
            this.tab_SingleTable.UseVisualStyleBackColor = true;
            // 
            // tab_MultiTable
            // 
            this.tab_MultiTable.Controls.Add(this.gbx_MultipleTables);
            this.tab_MultiTable.Location = new System.Drawing.Point(4, 22);
            this.tab_MultiTable.Name = "tab_MultiTable";
            this.tab_MultiTable.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MultiTable.Size = new System.Drawing.Size(908, 514);
            this.tab_MultiTable.TabIndex = 1;
            this.tab_MultiTable.Text = "Multiple Tables";
            this.tab_MultiTable.UseVisualStyleBackColor = true;
            // 
            // gbx_MultipleTables
            // 
            this.gbx_MultipleTables.Controls.Add(this.pnl_MultiTableMain);
            this.gbx_MultipleTables.Controls.Add(this.pnl_MultipleBottom);
            this.gbx_MultipleTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_MultipleTables.Location = new System.Drawing.Point(3, 3);
            this.gbx_MultipleTables.Name = "gbx_MultipleTables";
            this.gbx_MultipleTables.Size = new System.Drawing.Size(902, 508);
            this.gbx_MultipleTables.TabIndex = 7;
            this.gbx_MultipleTables.TabStop = false;
            // 
            // pnl_MultiTableMain
            // 
            this.pnl_MultiTableMain.Controls.Add(this.pnl_MultiSelectedColumns);
            this.pnl_MultiTableMain.Controls.Add(this.pnl_MultiSelectedTables);
            this.pnl_MultiTableMain.Controls.Add(this.pnl_MultiTableAddRemovePanel);
            this.pnl_MultiTableMain.Controls.Add(this.pnl_MultiTableListing);
            this.pnl_MultiTableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MultiTableMain.Location = new System.Drawing.Point(3, 16);
            this.pnl_MultiTableMain.Name = "pnl_MultiTableMain";
            this.pnl_MultiTableMain.Size = new System.Drawing.Size(896, 440);
            this.pnl_MultiTableMain.TabIndex = 5;
            // 
            // pnl_MultiSelectedColumns
            // 
            this.pnl_MultiSelectedColumns.Controls.Add(this.dgv_SelectedColumns);
            this.pnl_MultiSelectedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MultiSelectedColumns.Location = new System.Drawing.Point(599, 0);
            this.pnl_MultiSelectedColumns.Name = "pnl_MultiSelectedColumns";
            this.pnl_MultiSelectedColumns.Size = new System.Drawing.Size(297, 440);
            this.pnl_MultiSelectedColumns.TabIndex = 7;
            // 
            // dgv_SelectedColumns
            // 
            this.dgv_SelectedColumns.AllowUserToAddRows = false;
            this.dgv_SelectedColumns.AllowUserToDeleteRows = false;
            this.dgv_SelectedColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SelectedColumns.Location = new System.Drawing.Point(0, 0);
            this.dgv_SelectedColumns.Name = "dgv_SelectedColumns";
            this.dgv_SelectedColumns.RowHeadersVisible = false;
            this.dgv_SelectedColumns.Size = new System.Drawing.Size(297, 440);
            this.dgv_SelectedColumns.TabIndex = 4;
            // 
            // pnl_MultiSelectedTables
            // 
            this.pnl_MultiSelectedTables.Controls.Add(this.lbx_MultiSelectedTable);
            this.pnl_MultiSelectedTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MultiSelectedTables.Location = new System.Drawing.Point(321, 0);
            this.pnl_MultiSelectedTables.Name = "pnl_MultiSelectedTables";
            this.pnl_MultiSelectedTables.Size = new System.Drawing.Size(278, 440);
            this.pnl_MultiSelectedTables.TabIndex = 6;
            // 
            // lbx_MultiSelectedTable
            // 
            this.lbx_MultiSelectedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_MultiSelectedTable.FormattingEnabled = true;
            this.lbx_MultiSelectedTable.Location = new System.Drawing.Point(0, 0);
            this.lbx_MultiSelectedTable.Name = "lbx_MultiSelectedTable";
            this.lbx_MultiSelectedTable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx_MultiSelectedTable.Size = new System.Drawing.Size(278, 433);
            this.lbx_MultiSelectedTable.Sorted = true;
            this.lbx_MultiSelectedTable.TabIndex = 15;
            this.lbx_MultiSelectedTable.SelectedIndexChanged += new System.EventHandler(this.lbx_MultiSelectedTable_SelectedIndexChanged);
            // 
            // pnl_MultiTableAddRemovePanel
            // 
            this.pnl_MultiTableAddRemovePanel.Controls.Add(this.btn_AddTable);
            this.pnl_MultiTableAddRemovePanel.Controls.Add(this.btn_RemoveTable);
            this.pnl_MultiTableAddRemovePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MultiTableAddRemovePanel.Location = new System.Drawing.Point(278, 0);
            this.pnl_MultiTableAddRemovePanel.Name = "pnl_MultiTableAddRemovePanel";
            this.pnl_MultiTableAddRemovePanel.Size = new System.Drawing.Size(43, 440);
            this.pnl_MultiTableAddRemovePanel.TabIndex = 5;
            // 
            // btn_AddTable
            // 
            this.btn_AddTable.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_AddTable.Location = new System.Drawing.Point(3, 87);
            this.btn_AddTable.Name = "btn_AddTable";
            this.btn_AddTable.Size = new System.Drawing.Size(37, 23);
            this.btn_AddTable.TabIndex = 0;
            this.btn_AddTable.Text = ">>";
            this.btn_AddTable.UseVisualStyleBackColor = true;
            this.btn_AddTable.Click += new System.EventHandler(this.btn_AddTable_Click);
            // 
            // btn_RemoveTable
            // 
            this.btn_RemoveTable.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_RemoveTable.Location = new System.Drawing.Point(3, 116);
            this.btn_RemoveTable.Name = "btn_RemoveTable";
            this.btn_RemoveTable.Size = new System.Drawing.Size(37, 23);
            this.btn_RemoveTable.TabIndex = 1;
            this.btn_RemoveTable.Text = "<<";
            this.btn_RemoveTable.UseVisualStyleBackColor = true;
            this.btn_RemoveTable.Click += new System.EventHandler(this.btn_RemoveTable_Click);
            // 
            // pnl_MultiTableListing
            // 
            this.pnl_MultiTableListing.Controls.Add(this.lbx_MultiTableListing);
            this.pnl_MultiTableListing.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MultiTableListing.Location = new System.Drawing.Point(0, 0);
            this.pnl_MultiTableListing.Name = "pnl_MultiTableListing";
            this.pnl_MultiTableListing.Size = new System.Drawing.Size(278, 440);
            this.pnl_MultiTableListing.TabIndex = 17;
            // 
            // lbx_MultiTableListing
            // 
            this.lbx_MultiTableListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_MultiTableListing.FormattingEnabled = true;
            this.lbx_MultiTableListing.Location = new System.Drawing.Point(0, 0);
            this.lbx_MultiTableListing.Name = "lbx_MultiTableListing";
            this.lbx_MultiTableListing.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx_MultiTableListing.Size = new System.Drawing.Size(278, 433);
            this.lbx_MultiTableListing.Sorted = true;
            this.lbx_MultiTableListing.TabIndex = 16;
            // 
            // pnl_MultipleBottom
            // 
            this.pnl_MultipleBottom.Controls.Add(this.btn_PreviewMultipleTable);
            this.pnl_MultipleBottom.Controls.Add(this.btn_OutputFolder);
            this.pnl_MultipleBottom.Controls.Add(this.label13);
            this.pnl_MultipleBottom.Controls.Add(this.txt_OutputFolder);
            this.pnl_MultipleBottom.Controls.Add(this.btn_GenerateMultiTables);
            this.pnl_MultipleBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MultipleBottom.Location = new System.Drawing.Point(3, 456);
            this.pnl_MultipleBottom.Name = "pnl_MultipleBottom";
            this.pnl_MultipleBottom.Size = new System.Drawing.Size(896, 49);
            this.pnl_MultipleBottom.TabIndex = 6;
            // 
            // btn_PreviewMultipleTable
            // 
            this.btn_PreviewMultipleTable.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_PreviewMultipleTable.Location = new System.Drawing.Point(725, 13);
            this.btn_PreviewMultipleTable.Name = "btn_PreviewMultipleTable";
            this.btn_PreviewMultipleTable.Size = new System.Drawing.Size(75, 23);
            this.btn_PreviewMultipleTable.TabIndex = 27;
            this.btn_PreviewMultipleTable.Text = "Preview";
            this.btn_PreviewMultipleTable.UseVisualStyleBackColor = true;
            this.btn_PreviewMultipleTable.Click += new System.EventHandler(this.btn_PreviewMultipleTable_Click);
            // 
            // btn_OutputFolder
            // 
            this.btn_OutputFolder.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.btn_OutputFolder.Location = new System.Drawing.Point(690, 13);
            this.btn_OutputFolder.Name = "btn_OutputFolder";
            this.btn_OutputFolder.Size = new System.Drawing.Size(24, 23);
            this.btn_OutputFolder.TabIndex = 26;
            this.btn_OutputFolder.Text = "...";
            this.btn_OutputFolder.UseVisualStyleBackColor = true;
            this.btn_OutputFolder.Click += new System.EventHandler(this.btn_OutputFolder_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Export To: ";
            // 
            // txt_OutputFolder
            // 
            this.txt_OutputFolder.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.txt_OutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutputFolder.Location = new System.Drawing.Point(85, 16);
            this.txt_OutputFolder.Name = "txt_OutputFolder";
            this.txt_OutputFolder.Size = new System.Drawing.Size(599, 20);
            this.txt_OutputFolder.TabIndex = 14;
            // 
            // btn_GenerateMultiTables
            // 
            this.btn_GenerateMultiTables.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_GenerateMultiTables.Location = new System.Drawing.Point(806, 13);
            this.btn_GenerateMultiTables.Name = "btn_GenerateMultiTables";
            this.btn_GenerateMultiTables.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerateMultiTables.TabIndex = 1;
            this.btn_GenerateMultiTables.Text = "Generate";
            this.btn_GenerateMultiTables.UseVisualStyleBackColor = true;
            this.btn_GenerateMultiTables.Click += new System.EventHandler(this.btn_GenerateMultiTables_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.mnu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Exit});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.Size = new System.Drawing.Size(37, 20);
            this.mnu_File.Text = "File";
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(92, 22);
            this.mnu_Exit.Text = "Exit";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // mnu_Help
            // 
            this.mnu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About});
            this.mnu_Help.Name = "mnu_Help";
            this.mnu_Help.Size = new System.Drawing.Size(44, 20);
            this.mnu_Help.Text = "Help";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(107, 22);
            this.mnu_About.Text = "About";
            this.mnu_About.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // SqlScriptGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 684);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.pnl_ServerSelection);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject("$this.Icon") ) );
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SqlScriptGenerator";
            this.Text = "Insertion Script Generator";
            this.Load += new System.EventHandler(this.OnPageLoad);
            ( (System.ComponentModel.ISupportInitialize)( this.dgv_Result ) ).EndInit();
            this.gbx_DataCollection.ResumeLayout(false);
            this.pnl_GridMiddle.ResumeLayout(false);
            this.pnl_GridMiddle.PerformLayout();
            this.pnl_GridUpper.ResumeLayout(false);
            this.pnl_GridUpper.PerformLayout();
            this.pnl_GridTopRight.ResumeLayout(false);
            this.pnl_GridTopRight.PerformLayout();
            this.pnl_ServerSelection.ResumeLayout(false);
            this.pnl_ServerSelection.PerformLayout();
            this.tab_Main.ResumeLayout(false);
            this.tab_SingleTable.ResumeLayout(false);
            this.tab_MultiTable.ResumeLayout(false);
            this.gbx_MultipleTables.ResumeLayout(false);
            this.pnl_MultiTableMain.ResumeLayout(false);
            this.pnl_MultiSelectedColumns.ResumeLayout(false);
            ( (System.ComponentModel.ISupportInitialize)( this.dgv_SelectedColumns ) ).EndInit();
            this.pnl_MultiSelectedTables.ResumeLayout(false);
            this.pnl_MultiTableAddRemovePanel.ResumeLayout(false);
            this.pnl_MultiTableListing.ResumeLayout(false);
            this.pnl_MultipleBottom.ResumeLayout(false);
            this.pnl_MultipleBottom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_ServerList;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.RadioButton rbn_WindowsSecurity;
        private System.Windows.Forms.RadioButton rbn_SQLLogin;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_DatabaseList;
        private System.Windows.Forms.ComboBox cbx_TableList;
        private System.Windows.Forms.ComboBox cbx_ViewList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbx_DataCollection;
        private System.Windows.Forms.Panel pnl_GridMiddle;
        private System.Windows.Forms.Button btn_GenerateFromGrid;
        private System.Windows.Forms.Panel pnl_GridUpper;
        private System.Windows.Forms.TextBox txt_SelectionScript;
        private System.Windows.Forms.Button btn_RunScript;
        private System.Windows.Forms.TextBox txt_RowCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_ServerSelection;
        private System.Windows.Forms.Button btn_AutomateScript;
        private System.Windows.Forms.TextBox txt_Replace;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Panel pnl_GridTopRight;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_ColumnList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_ReOrdering;
        private System.Windows.Forms.TextBox txt_IncrementValue;
        private System.Windows.Forms.TextBox txt_ReOrderFrom;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tab_SingleTable;
        private System.Windows.Forms.TabPage tab_MultiTable;
        private System.Windows.Forms.Button btn_AddTable;
        private System.Windows.Forms.Button btn_RemoveTable;
        private System.Windows.Forms.DataGridView dgv_SelectedColumns;
        private System.Windows.Forms.Panel pnl_MultiTableMain;
        private System.Windows.Forms.GroupBox gbx_MultipleTables;
        private System.Windows.Forms.Panel pnl_MultipleBottom;
        private System.Windows.Forms.Panel pnl_MultiTableAddRemovePanel;
        private System.Windows.Forms.Panel pnl_MultiSelectedTables;
        private System.Windows.Forms.Panel pnl_MultiSelectedColumns;
        private System.Windows.Forms.Button btn_GenerateMultiTables;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_OutputFolder;
        private System.Windows.Forms.FolderBrowserDialog fbd_OutputFolder;
        private System.Windows.Forms.Button btn_OutputFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ListBox lbx_MultiSelectedTable;
        private System.Windows.Forms.ListBox lbx_MultiTableListing;
        private System.Windows.Forms.Panel pnl_MultiTableListing;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_PreviewMultipleTable;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.CheckBox chk_IncludeGuidColumn;

    }
}

