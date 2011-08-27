using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SqlScriptGenerator
{
    public class SqlHelper
    {
        public const string DATETIME_FORMAT = "yyyy-MM-dd HH:mm:ss.fff";
        public const string DATE_FORMAT = "yyyy-MM-dd";


        #region ToSQLString
        public static string ToSQLString(string dotNetString)
        {
            return SqlHelper.ToSQLString(dotNetString, typeof(string));
        }
        private static string ToSQLString(object argValue, System.Type type)
        {
            if (argValue == System.DBNull.Value)
            {
                return "NULL";
            }
            else if (type == typeof(string))
            {
                return "'" + argValue.ToString().Replace("'", "''") + "'";
            }
            else if (type == typeof(DateTime))
            {
                return "CONVERT(DATETIME, '" + ((DateTime)argValue).ToString(DATETIME_FORMAT, System.Globalization.DateTimeFormatInfo.InvariantInfo) + "', 120)";
            }
            else if (type == typeof(int)
                || type == typeof(System.Int16) || type == typeof(System.Int32) || type == typeof(System.Int64))
            {
                return argValue.ToString();
            }
            else if (type == typeof(bool))
            {
                if (bool.Parse(argValue.ToString()) == true)
                    return "1";
                else
                    return "0";
            }
            else if (type == typeof(decimal) || type == typeof(double))
            {
                return Convert.ToDecimal(argValue).ToString("G");
            }
            else if (type == typeof(System.Guid))
            {
                return "'" + argValue.ToString() + "'";
            }
            else
            {
                throw new Exception("Invalid data type : " + type.ToString());
            }
        }

        #endregion

        #region For Generating Insertion SQL Script
        public static string GenerateInsertionSQLScriptFromDataTable(DataTable table)
        {
            return SqlHelper.GenerateInsertionSQLScriptFromDataTable(table.TableName, table);
        }

        public static string GenerateInsertionSQLScriptFromDataTable(DataTable table, ArrayList includedColumnNames)
        {
            return SqlHelper.GenerateInsertionSQLScriptFromDataTable(table.TableName, table, includedColumnNames);
        }

        public static string GenerateInsertionSQLScriptFromDataTable(string SQLTableName, DataTable table)
        {
            return SqlHelper.GenerateInsertionSQLScriptFromDataTable(SQLTableName, table, new ArrayList(table.Columns));
        }

        public static string GenerateInsertionSQLScriptFromDataTable(string SQLTableName, DataTable table, ArrayList includedColumnNames)
        {
            StringBuilder builder = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                {
                    builder.Append(SqlHelper.GenerateDataRowInsertSQLScript(SQLTableName, row, includedColumnNames));
                }
            }
            return builder.ToString();
        }

        private static string GenerateDataRowInsertSQLScript(string SQLTableName, DataRow row, ArrayList includedColumnNames)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" INSERT INTO [").Append(SQLTableName).Append("] ( ");
            for (int cnt = 0; cnt < includedColumnNames.Count; cnt++)
            {
                if (cnt != 0)
                    builder.Append(", ");
                builder.Append("[").Append(includedColumnNames[cnt].ToString()).Append("]");
            }
            builder.Append(" ) ").Append(Environment.NewLine);

            builder.Append(" VALUES ( ");
            for (int cnt = 0; cnt < includedColumnNames.Count; cnt++)
            {
                if (cnt != 0)
                    builder.Append(", ");

                string columnName = includedColumnNames[cnt].ToString();
                builder.Append(SqlHelper.ToSQLString(row[columnName], row.Table.Columns[columnName].DataType));
            }
            builder.Append(" ) ").Append(Environment.NewLine).Append(Environment.NewLine);

            return builder.ToString();
        }
        #endregion

        #region For Generating Selection SQL Script
        public static string GenerateSelectionSQLScript(string tableName, ArrayList includedColumnNames)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            for (int cnt = 0; cnt < includedColumnNames.Count; cnt++)
            {
                string columnName = includedColumnNames[cnt].ToString().Trim();

                if (cnt != 0)
                    builder.Append(", ");

                builder.Append("[").Append(columnName).Append("]");
            }
            builder.Append(" FROM ").Append("[").Append(tableName).Append("]");

            return builder.ToString();
        }
        #endregion

        #region static int ReplaceValueByColumn(DataTable table, string columnName, string find, string replace)
        public static int ReplaceValueByColumn(DataTable table, string columnName, string find, string replace)
        {
            int cnt = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;

                string originalValue = row[columnName].ToString();
                if (originalValue.IndexOf(find) > -1)
                {
                    cnt++;
                    string replacedValue = originalValue.Replace(find, replace);
                    row[columnName] = replacedValue;
                }
            }
            return cnt;
        }
        #endregion

        #region static void ReOrderValueByColumn(DataTable table, string columnName, int reOrderFromValue, int incrementValue)
        public static void ReOrderValueByColumn(DataTable table, string columnName, int reOrderFromValue, int incrementValue)
        {
            int count = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;

                row[columnName] = reOrderFromValue + count;
                count += incrementValue;
            }
        }
        #endregion
    }
}
