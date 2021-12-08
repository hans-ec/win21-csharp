using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace _03_TDD.xUnitTests
{
    internal class CustomerService
    {
        private HttpClient client;


        public CustomerService()
        {
            client = new HttpClient();
        }

        internal async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await client.GetFromJsonAsync<IEnumerable<Customer>>("");
        }
    }
}