using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers_ClassLibrary
{
    internal class InheritanceExample : Repository
    {
        public InheritanceExample()
        {
            /* funkar */
            PublicMethod();
            InternalMethod();
            ProtectedMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();

            /* funkar inte */
            PrivateMethod();
        }

        public void InheritanceExampleMethod()
        {
            /* funkar */
            PublicMethod();
            InternalMethod();
            ProtectedMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();

            /* funkar inte */
            PrivateMethod();
        }
    }
}
