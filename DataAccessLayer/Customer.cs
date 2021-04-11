using System;

namespace DataAccessLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string City { get; set; }
        public string PickupDate { get; set; }
    }
}
