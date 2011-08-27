using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SqlScriptGenerator
{
    public class UIHelper
    {
        #region static void SetGridColumnWidth(System.Windows.Forms.DataGridView dgv)
        public static void SetGridColumnWidth(System.Windows.Forms.DataGridView dgv)
        {
            foreach (System.Windows.Forms.DataGridViewColumn column in dgv.Columns)
            {
                column.Width = column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.DisplayedCells, true);
            }
        }
        #endregion
    }

}
