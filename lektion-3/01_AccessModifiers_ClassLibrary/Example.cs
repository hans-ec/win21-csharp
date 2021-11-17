using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers_ClassLibrary
{
    internal class Example
    {
        Repository repo = new Repository();

        public Example()
        {
            /* funkar */
            repo.PublicMethod();         
            repo.InternalMethod();
            repo.ProtectedInternalMethod();


            /* funkar inte */
            repo.PrivateMethod();
            repo.ProtectedMethod();
            repo.PrivateProtectedMethod();
        }


        public void ExampleMethod()
        {
            /* funkar */
            repo.PublicMethod();
            repo.InternalMethod();
            repo.ProtectedInternalMethod();


            /* funkar inte */
            repo.PrivateMethod();
            repo.ProtectedMethod();
            repo.PrivateProtectedMethod();
        }
    }
}
