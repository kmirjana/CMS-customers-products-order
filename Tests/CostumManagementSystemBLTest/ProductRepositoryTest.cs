using System;
using CostumManagementSystem.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CostumManagementSystemBLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
         [TestMethod]
        public void RetriveValid()
        {
            var productRepository = new ProductRepositiory();
            var expected = new Product(1)
            {
                Name = "Chair",
                Current_price = 2500m,
                Description = "Oak wood,120cm high",
            };


            //act

            var actual = productRepository.Retrive(1);

            //assert
         
            Assert.AreEqual(expected.Description , actual.Description );
            Assert.AreEqual(expected.Current_price , actual.Current_price );
            Assert.AreEqual(expected.Name , actual.Name);
            Assert.AreEqual(expected.ProductId , actual.ProductId);
        }
        [TestMethod()]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepositiory();
            var UpdatedProduct = new Product(2)
            {
                Current_price = 18M,
                Description = "Wooden oak 50cm high table",
                Name = "Table",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(UpdatedProduct);
            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepositiory();
            var UpdatedProduct = new Product(2)
            {
                Current_price = null,
                Description = "Wooden oak 50cm high table",
                Name = "Table",
                HasChanges = true
            };
            //Act
            var actual = productRepository.Save(UpdatedProduct);
            //Assert

            Assert.AreEqual(false, actual);
        }
    }
}
