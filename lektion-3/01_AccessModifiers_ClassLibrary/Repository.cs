using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers_ClassLibrary
{
    public class Repository
    {
        public Repository()
        {
            /* funkar */
            PublicMethod();
            PrivateMethod();
            InternalMethod();
            ProtectedMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();

            /* funkar inte */
        }

        public void PublicMethod() 
        {
            PrivateMethod();
        }
        private void PrivateMethod() { }
        internal void InternalMethod() { }
        protected void ProtectedMethod() { }
        protected internal void ProtectedInternalMethod() { }
        private protected void PrivateProtectedMethod() { }

    }
}
