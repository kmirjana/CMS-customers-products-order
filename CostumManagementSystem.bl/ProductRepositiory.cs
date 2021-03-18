using CostumManagementSystemBLTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystem.bl
{
    public class ProductRepositiory
    {
        public Product Retrive (int productId)
        {
            Product product = new Product(productId);
            if (productId == 1)
            {
                product.Current_price = 2500m;
                product.Description = "Oak wood,120cm high";
                product.Name = "Chair";
            }
            Object myObject = new Object();
            Console.WriteLine($"Object:{myObject.ToString()}");
            Console.WriteLine($"Product :{product.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an inserted stored procedure
                    }

                    else
                    {
                        //  Call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }

            }
            return success;
        }

    }
}
