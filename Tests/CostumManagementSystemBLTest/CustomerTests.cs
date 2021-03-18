using System;
using CostumManagementSystem.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CostumManagementSystemBLTest
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrage

            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

             //Act

            string actual = customer.FullName;

            //Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameValid()
        {
            //Arrage

            Customer customer = new Customer
            {
                FirstName = "Bilbo",

            };
            string expected = "Bilbo";

            //Act

            string actual = customer.FullName;

            //Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod ]
        public void StatictTest()
        {
            //Arrange 
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Dorian";
            Customer.InstanceCount += 1;
            //Act

            //Assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        { 
            //Arrange

            var customer = new Customer
            {
                LastName = "Bardem",
                Email = "Bardem@hollywood.com"
             };

            var expected = true;

            //Actual

            var actual = customer.Validate();

            //Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange

            var customer = new Customer
            {
                
                Email = "Bardem@hollywood.com"
            };

            var expected = false;//true;

            //Actual

            var actual = customer.Validate();

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
