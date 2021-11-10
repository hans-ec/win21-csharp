using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSharpFundimentals
{
    internal class VariableExample
    {

        private int myField;

        public int MyProperty
        {
            get { return myField; }
            set { myField = value; }
        }

        public void MyMethod(string parameter)
        {
            var _variable = "";
            dynamic dynamicVariable = "";
        }

    }
}
