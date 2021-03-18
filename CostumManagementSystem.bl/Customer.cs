using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystem.bl
{
    public class Customer
    {
        public Customer():this(0)//constr. chaninig//calling construct. below
            // 0 is id parameter
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }// the default is null, to prevent need to modify default constrr.
        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; } //Added to extra for choosing different types of customers
        public string  Email { get; set; }
        private string _lastName;// for holding the value backing 
        public string  FirstName { get; set; }
        public string FullName
        {
            get

            {
                string fullName = LastName;
                if (!string .IsNullOrWhiteSpace(FirstName))
                {
                    if (!string .IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email))isValid = false;

            return isValid;
        }
        //public Customer Retrive (int customerId) //returns specific customer by ID
        //{
        //    return new Customer() ;
        //}
        //public List <Customer> Retrive()
        //{
        //    return new List<Customer>();
        //}
        //public bool Save()
        //{
        //    return true;
        //}
        
    }
}
