using _03_Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstracts.Models
{
    /*
        SQL SYNTAXER (MSSQL - Microsoft Sql Server, MySQL, PostgreSQL, Oracle SQL)
        -------------------------------------------------------------------------------------------------
        ANSLUT          using (var conn = new SqlConnection("connectionstring")) { conn.Open(); }
        SPARA           INSERT INTO Customers VALUES ('Hans','Mattin-Lassei','hans@domain.com')
        HÄMTA           SELECT * FROM Customers 
    */


    internal class SqlStorage : DataStorage
    {
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("using (var conn = new SqlConnection(\"connectionstring\")) { conn.Open(); }");
        }

        public override void Create(dynamic context)
        {
            Console.WriteLine($"INSERT INTO Customers VALUES ({context.firstName},{context.lastName},{context.email})");
        }

        public override void Get()
        {
            Console.WriteLine("SELECT * FROM Customers ");
        }
    }
}
