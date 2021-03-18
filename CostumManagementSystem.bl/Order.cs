using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystemBLTest
{
    public class Order
    {
        public Order():this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<ItemOrder>();
        }
        public int CustomerId { get; set; }
        public DateTimeOffset ? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<ItemOrder> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public override string ToString()=>
        
            $"{OrderDate.Value.Date}({OrderId})";
       
        //public Order Retrive (int orderId)
        //{
        //    return new Order();
        //}
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = true;
            return isValid;
        }
        //public bool Save()
        //{
        //    return true;
        //}
    }

}
