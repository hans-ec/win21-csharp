using _01_AccessModifiers_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers
{
    internal class Example
    {
        Repository repo = new Repository();

        public Example()
        {
            /* funkar */
            repo.PublicMethod();


            /* funkar inte */
            repo.PrivateMethod();
            repo.InternalMethod();
            repo.ProtectedMethod();
            repo.ProtectedInternalMethod();
            repo.PrivateProtectedMethod();
        }

        public void ExampleMethod()
        {
            /* funkar */
            repo.PublicMethod();


            /* funkar inte */
            repo.PrivateMethod();
            repo.InternalMethod();
            repo.ProtectedMethod();
            repo.ProtectedInternalMethod();
            repo.PrivateProtectedMethod();
        }
    }
}
