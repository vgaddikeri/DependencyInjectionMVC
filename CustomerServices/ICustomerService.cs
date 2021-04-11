using System.Collections.Generic;
using DataAccessLayer;

namespace CustomerServices
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
