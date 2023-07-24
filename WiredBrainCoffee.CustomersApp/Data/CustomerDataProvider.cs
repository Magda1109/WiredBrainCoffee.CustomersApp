using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100);
            return new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Julia", LastName = "Abc", IsDeveloper = true },
                new Customer { Id = 1, FirstName = "Alex", LastName = "Kowalski" },
                new Customer { Id = 1, FirstName = "Julia", LastName = "Smith", IsDeveloper = true },
                new Customer { Id = 1, FirstName = "Adam", LastName = "Japan", IsDeveloper = true },
                new Customer { Id = 1, FirstName = "John", LastName = "Miller", IsDeveloper = false },
                new Customer { Id = 1, FirstName = "Magda", LastName = "Nowak", },
            };
        }
    }
}
