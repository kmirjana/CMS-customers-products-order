using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystemBLTest
{
    public class ItemOrder
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal ? PurchasePrice { get; set; }
        public int OrderId { get; set; }

        public ItemOrder()
        {

        }
        public ItemOrder(int orderId)
        {
            orderId = OrderId;
        }
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
        public ItemOrder  Retrive(int orderId) //returns specific customer by ID
        {
            return new ItemOrder ();
        }
        public List<ItemOrder > Retrive()
        {
            return new List<ItemOrder >();
        }
        public bool Save()
        {
            return true;
        }
    }
}
