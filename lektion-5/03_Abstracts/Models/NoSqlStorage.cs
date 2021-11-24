using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstracts.Models
{
    internal class NoSqlStorage : DataStorage
    {
        /*
            NOSQL SYNTAXER (MonogDB, MariaDB, CosmosDB, Cassandra...)
            -------------------------------------------------------------------------------------------------
            ANSLUT          _context.connect("connectionstring");
            SPARA           _context.Customers.Add(customer); _context.SaveChanges();
            HÄMTA           _context.Customers.ToList();
        */

        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("_context.connect(\"connectionstring\");");
        }


        public override void Create(dynamic context)
        {
            Console.WriteLine($"_context.Customers.Add({context}); _context.SaveChanges();");
        }

        public override void Get()
        {
            Console.WriteLine("_context.Customers.ToList();");
        }
    }
}
