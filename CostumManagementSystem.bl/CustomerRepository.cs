using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystem.bl
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrive(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.Email = "javierbaredem@vinales.com";
                customer.FirstName = "Javier";
                customer.LastName = "Bardem";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;//saves current customer
            
        }

        public bool Save(Customer customer)
        {
            return true;//saves passed in customer
        }
    }
}
