using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Handlers
{
    public interface IFileHandler
    {
        bool SaveToFile(List<Customer> customerList, string v);
        bool ReadFromFile(string filePath);
    }

    public class FileHandler : IFileHandler
    {
        private ICustomerHandler _customerHandler = new CustomerHandler();


        public bool ReadFromFile(string filePath)
        {
           try
            {
                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        var values = line.Split(";");
                        _customerHandler.AddToList(new Customer
                        {
                            Id = Guid.Parse(values[0]),
                            Name = values[1],
                            Email = values[2]
                        });
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public bool SaveToFile(List<Customer> customerList, string filePath)
        {
            try
            {
                var path = Path.GetDirectoryName(filePath);

                if(!string.IsNullOrEmpty(path))
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                using (var sw = new StreamWriter(filePath))
                {
                    foreach (var customer in customerList)
                        sw.WriteLine($"{customer.Id};{customer.Name};{customer.Email}");
                }

                return true;
            }
            catch { return false; }
        }
    }
}
