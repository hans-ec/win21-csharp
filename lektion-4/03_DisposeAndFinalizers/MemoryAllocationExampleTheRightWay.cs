using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DisposeAndFinalizers
{
    internal class MemoryAllocationExampleTheRightWay
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\EC\WIN21\csharp\lektion-4\03_DisposeAndFinalizers\Data\db.mdf;Integrated Security=True";

        public void Run() 
        {
            var tableNames = GetTableNames(_connectionString);
            var tableRowCounts = GetTableRowCounts(tableNames, _connectionString);

            foreach(var row in tableRowCounts)
                Console.WriteLine($"{row.Key}: {row.Value}");
        }
        
        public List<string> GetTableNames(string connectionString) 
        {
            List<string> tableNames = new();
            int counter = 0;

            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", conn))
                {
                    conn.Open();
                    var result = cmd.ExecuteReader();

                    while (result.Read())
                    {
                        tableNames.Add(result[0].ToString());
                        Console.WriteLine($"TableName Proccessed: {++counter}");
                    }
                        
                }
            }

            return tableNames;
        }
        
        public Dictionary<string, int> GetTableRowCounts(List<string> tableNames, string connectionString) 
        {
            Dictionary<string, int> tableRowCounts = new();
            var counter = 0;

            foreach (var tableName in tableNames)
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand($"SELECT COUNT(*) FROM {tableName}", conn))
                    {
                        conn.Open();
                        tableRowCounts.Add(tableName, int.Parse(cmd.ExecuteScalar().ToString()));
                        Console.WriteLine($"TableRowCount Proccessed: {++counter}");
                    }
                }
            }

            return tableRowCounts;
        }

    }
}
