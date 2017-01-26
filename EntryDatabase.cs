using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Library
{
    public class EntryDatabase
    {
        SqlConnection connection = new SqlConnection
        {
            ConnectionString = ""
        };


        public EntryDatabase()
        {
            CreateDB();
        }

        // create db if not exists
        private void CreateDB()
        {
            connection.Open();

            string cmdText = "CREATE OR REPLACE TABLE PHPLibraryEntries (ID INT NOT NULL, Description VARCHAR2(MAX), Content VARCHAR(MAX), PRIMARY KEY (ID));";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.ExecuteNonQuery();

            connection.Close();
        }







    }
}
