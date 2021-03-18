using System;

namespace CostumManagementSystemBLTest
{
    public  class OrderRepository
    {
        
        public Order Retrive(int orderId)
            {
                Order order = new Order( orderId);
                if (orderId == 10)
                {
                order.OrderDate = new System.DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new System.TimeSpan(7, 0, 0));
                }
                return order;
            }
            public bool Save(Order order)
            {
                return true;
            }
        
    }
}