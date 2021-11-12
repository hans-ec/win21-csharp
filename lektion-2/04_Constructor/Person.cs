using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constructor
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
    }
}
