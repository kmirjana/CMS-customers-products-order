using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystem.bl
{
   public class AddressRepository
    {
        //retrive one address

        public Address Retrieve (int addressId)

        {
            // Create the instance of the address class
            //pass in the requested Id

            Address address = new Address(addressId);

            //code that retrieves the defined address
            // temporary hard coded values to return populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Jose Marti";
                address.StreetLine2 = "Vinales234";
                address.City = "Havana";
                address.Country = "Cubana";
                address.PostalCode="3344";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {

            // Ienumerable returns a sequence of data//
            var addresslist = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Jorge Balaboa",
                StreetLine2 = "Jose Pinales",
                City = "Trinidad",
                State = "Cuba",
                Country = "Caribian",
                PostalCode = "3344"
            };

            addresslist.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Maria Villa",
                StreetLine2 = "Paco Tinieblas",
                City = "Pamplona",
                Country = "Espania",
                PostalCode = "2000"
,
            };

            addresslist.Add(address);
            return addresslist;

        }

        // saves the current address

        public bool Save(Address address)
        {
            // code that saves the passed in address

            return true;
        }
        
    }
}
