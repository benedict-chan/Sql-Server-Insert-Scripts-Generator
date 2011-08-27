using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SqlScriptGenerator
{

    public class LogHelper
    {
        #region public static string GenerateTabDelimitedTextWithDataTable(System.Data.DataTable outputTable, bool withHeader)
        public static string GenerateTabDelimitedTextWithDataTable(System.Data.DataTable outputTable, bool withHeader)
        {
            StringBuilder builder = new StringBuilder();
            if (withHeader)
            {
                foreach (System.Data.DataColumn column in outputTable.Columns)
                {
                    builder.Append(column.ColumnName.Trim());
                    builder.Append("\t");
                }
                builder.Append(Environment.NewLine);
            }
            foreach (System.Data.DataRow row in outputTable.Rows)
            {
                foreach (System.Data.DataColumn column in outputTable.Columns)
                {
                    builder.Append(LogHelper.ConvertFieldToString(column.DataType, row[column]).Trim());
                    builder.Append("\t");
                }
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }

        #endregion
        #region public static string GenerateFixedLengthTextWithDataTable(System.Data.DataTable outputTable, bool withHeader, int[] fixedLengthArrayForEachColumn)
        public static string GenerateFixedLengthTextWithDataTable(System.Data.DataTable outputTable, bool withHeader, int[] fixedLengthArrayForEachColumn)
        {
            if (outputTable.Columns.Count != fixedLengthArrayForEachColumn.Length)
                throw new Exception("No. of columns does not match output");

            StringBuilder builder = new StringBuilder();
            if (withHeader)
            {
                for (int cnt = 0; cnt < outputTable.Columns.Count; cnt++)
                {
                    System.Data.DataColumn column = outputTable.Columns[cnt];
                    builder.Append(LogHelper.FixedLengthString(column.ColumnName.Trim(), fixedLengthArrayForEachColumn[cnt]));
                }
                builder.Append(Environment.NewLine);
            }
            foreach (System.Data.DataRow row in outputTable.Rows)
            {
                for (int cnt = 0; cnt < outputTable.Columns.Count; cnt++)
                {
                    System.Data.DataColumn column = outputTable.Columns[cnt];
                    builder.Append(LogHelper.FixedLengthString(LogHelper.ConvertFieldToString(column.DataType, row[column]).Trim(), fixedLengthArrayForEachColumn[cnt]));
                }
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }

        #endregion
        #region public static void SaveStringAs(string stringToSave)
        public static void SaveStringAs(string stringToSave)
        {
            LogHelper.SaveStringAs(stringToSave, null);
        }
        public static void SaveStringAs(string stringToSave, System.Windows.Forms.IWin32Window owner)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.OverwritePrompt = false;

            System.Windows.Forms.DialogResult result;
            if (owner != null)
                result = saveFileDialog.ShowDialog(owner);
            else
                result = saveFileDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false);
                writer.Write(stringToSave);
                writer.Close();
                //				MessageDialog.ShowMessage("Files Saved in " + saveFileDialog.FileName);
                System.Diagnostics.Process.Start("Notepad.exe", saveFileDialog.FileName);
            }
        }
        #endregion

        #region SaveStringToLocation
        public static void SaveStringToLocation(string stringToSave, string filePathToSave)
        {
            LogHelper.SaveStringToLocation(stringToSave, filePathToSave, Encoding.Default);
        }
        public static void SaveStringToLocation(string stringToSave, string filePathToSave, Encoding encoding)
        {
            StreamWriter writer = new StreamWriter(filePathToSave, false, encoding);
            writer.Write(stringToSave);
            writer.Close();
        } 
        #endregion


        #region private static string FixedLengthString(string inputString, int fixedLength)
        private static string FixedLengthString(string inputString, int fixedLength)
        {
            string result = inputString;
            if (inputString.Length <= fixedLength)
                result += new string(' ', fixedLength - inputString.Length);
            else
                result = inputString.Substring(0, fixedLength);

            return result;
        }
        #endregion
        #region private static string ConvertFieldToString(System.Type type, object oldValue)
        private static string ConvertFieldToString(System.Type type, object oldValue)
        {
            string result = string.Empty;
            if (oldValue is System.DBNull)
                return result;

            if (type == typeof(System.Decimal))
            {
                result = ((decimal)oldValue).ToString("G");
            }
            else if (type == typeof(System.DateTime))
            {
                result = ((DateTime)oldValue).ToString("yyyy-MM-dd");
            }
            else
            {
                result = oldValue.ToString();
            }
            return result;
        }

        #endregion


        #region private static void WriteLogFileLine(string folderName, string logFilePrefixName, string logMsgLine)
        public static void WriteLogFileLine(string folderName, string logFilePrefixName, string logMsgLine)
        {
            try
            {
                string fileName;
                fileName = String.Format("{0}_{1:yyyy-MM-dd}.txt", logFilePrefixName, DateTime.Now);
                if (!folderName.EndsWith(@"\"))
                    folderName += @"\";
                StreamWriter writer = new StreamWriter(folderName + fileName, true);
                writer.WriteLine(String.Format("[{0:T}]\t\t{1}", DateTime.Now, logMsgLine));
                writer.Close();
            }
            catch
            {

            }
        }
        #endregion
        #region private static void CheckAndCreateFolder(string folderName)
        private static void CheckAndCreateFolder(string folderName)
        {
            System.IO.DirectoryInfo logDir = new DirectoryInfo(folderName);
            if (!logDir.Exists)
                logDir.Create();
        }
        #endregion
    }

}
