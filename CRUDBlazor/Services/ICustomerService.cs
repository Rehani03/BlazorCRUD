using CRUDBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBlazor.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> Get();
        Task<Customer> Get(int id);
        Task<Customer> Add(Customer customer);
        Task<Customer> Update(Customer customer);
        Task<Customer> Delete(int id);
    }
}
