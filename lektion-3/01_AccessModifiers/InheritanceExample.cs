using _01_AccessModifiers_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers
{
    internal class InheritanceExample : Repository
    {
        public InheritanceExample()
        {
            /* funkar */
            PublicMethod();
            ProtectedMethod();
            ProtectedInternalMethod();

            /* funkar inte */
            PrivateMethod();
            InternalMethod();
            PrivateProtectedMethod();
        }

        public void InheritanceExampleMethod()
        {
            /* funkar */
            PublicMethod();
            ProtectedMethod();
            ProtectedInternalMethod();

            /* funkar inte */
            PrivateMethod();
            InternalMethod();
            PrivateProtectedMethod();
        }
    }
}
