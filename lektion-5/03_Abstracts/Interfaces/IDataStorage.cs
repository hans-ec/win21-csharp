using _03_Abstracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstracts.Interfaces
{
    internal interface IDataStorage
    {
        void Connect(string connectionString);
        void Create();
        IEnumerable<string> Get();
    }
}
