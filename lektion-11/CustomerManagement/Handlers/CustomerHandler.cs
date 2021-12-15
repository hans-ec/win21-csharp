using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Handlers
{
    public interface ICustomerHandler
    {
        bool AddToList(Customer customer);
        Customer GetCustomerFromList(Guid id);
        bool RemoveFromList(Guid id);
    }


    public class CustomerHandler : ICustomerHandler
    {
        private List<Customer> _customerList = new List<Customer>();



        public bool AddToList(Customer customer)
        {
            try
            {
                _customerList.Add(customer);
                return true;
            }
            catch {  return false; }
        }


        public Customer GetCustomerFromList(Guid id)
        {
            var customer = _customerList.FirstOrDefault(x => x.Id == id);
            if (customer != null)
                return customer;

            return null;
        }


        public bool RemoveFromList(Guid id)
        {
            var customer = _customerList.FirstOrDefault(x => x.Id == id);
            if(customer != null && customer.Id == id)
            {
                _customerList = _customerList.Where(x => x.Id != customer.Id).ToList();
                return true;
            }

            return false;

        }
    }
}
