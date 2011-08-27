using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SqlScriptGenerator
{

    public class SqlConnectionHelper
    {
        public static string GetConnectionString(string dataSource, string databaseName, bool windowsSecurity, string userName, string password)
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = dataSource;
            sqlBuilder.IntegratedSecurity = windowsSecurity;
            sqlBuilder.UserID = userName;
            sqlBuilder.Password = password;
            sqlBuilder.InitialCatalog = databaseName;
            return sqlBuilder.ToString();
        }

    }
}
