using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Handlers
{
    public interface IMenuHandler
    {
        int MenuOptions();
        void MenuOptionAdd();
        void MenuOptionRemove();
        void MenuOptionGet();
        void MenuOptionView();
        void MenuOptionSave();
    }

    public class MenuHandler : IMenuHandler
    {
        private ICustomerHandler customerHandler = new CustomerHandler(); 

        public void MenuOptionAdd()
        {
            var customer = new Customer();
            customer.Id = Guid.NewGuid();

            Console.Clear();
            Console.WriteLine("#########################");
            Console.WriteLine("###  CREATE CUSTOMER  ###");
            Console.WriteLine("#########################");
            Console.Write("Enter Name: ");
            customer.Name = Console.ReadLine() ?? "";
            Console.Write("Enter Email: ");
            customer.Email = Console.ReadLine() ?? "";

            customerHandler.AddToList(customer);
        }

        public int MenuOptions()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("#########################");
                Console.WriteLine("########  MENU  #########");
                Console.WriteLine("#########################");
                Console.WriteLine("");
                Console.WriteLine("1. Create Customer");
                Console.WriteLine("2. Remove Customer");
                Console.WriteLine("3. Get Customer");
                Console.WriteLine("4. View CustomerList");
                Console.WriteLine("5. Save CustomerList");
                Console.WriteLine("0. Quit");
                Console.WriteLine("");
                Console.Write("Choose one option between (0-5): ");
                return int.Parse(Console.ReadLine() ?? "-1");
            }
            catch { return -1; }
        }

        public void MenuOptionRemove()
        {
            throw new NotImplementedException();
        }

        public void MenuOptionGet()
        {
            throw new NotImplementedException();
        }

        public void MenuOptionView()
        {
            throw new NotImplementedException();
        }

        public void MenuOptionSave()
        {
            throw new NotImplementedException();
        }
    }
}
