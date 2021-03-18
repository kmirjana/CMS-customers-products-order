using System;
using CostumManagementSystem.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CostumManagementSystemBLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            // Arrange
            var customerReposiory = new CustomerRepository();
            var expected = new Customer(1)
            {
                //customerId = 1,
                Email = "javierbaredem@vinales.com",
                FirstName = "Javier",
                LastName = "Bardem"
            };


            //Actual
            var actual = customerReposiory.Retrive(1);
            //Assert
           
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }
        [TestMethod ]
        public void RetriveMissingLastName()
        {
            //Arrange
            //Actual
            //Assert
        }

    }
}
