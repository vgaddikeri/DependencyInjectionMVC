using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class CustomerRepository: ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                //In real time we get data from database using EF or something else
                new Customer{CustomerId=101,Name="Maria",City="Miami",ServiceID=2,ServiceName="Recycle Pickup",PickupDate="2021/04/12"},
                 new Customer{CustomerId=102,Name="Neha",City="Weston",ServiceID=1,ServiceName="Bulk Pickup",PickupDate="2021/04/18"},
                  new Customer{CustomerId=103,Name="Mel",City="Coral Gables",ServiceID=5,ServiceName="Electronic Equipment Pickup",PickupDate="2021/04/22"},
                   new Customer{CustomerId=104,Name="Jose",City="Boca Raton",ServiceID=4,ServiceName="Quick pickup",PickupDate= "2021/04/11"},
                    new Customer{CustomerId=105,Name="Gib",City="Homestead",ServiceID=3,ServiceName="Variable Pickup",PickupDate="2021/04/12"},
                     new Customer{CustomerId=106,Name="Ana",City="Key West",ServiceID=7,ServiceName="Curbside Pickup",PickupDate="2021/04/20"},
            };

        }
    }
}
