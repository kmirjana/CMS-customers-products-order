using CostumManagementSystem.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumManagementSystemBLTest
{
     public class Product : EntityBase
    {
        public Product(int productId)
        {
            ProductId = productId;
        }

        public string Description { get; set; }
        public decimal? Current_price { get; set; }
        public int ProductId { get; private set; }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        
        public override string ToString() => Name;

        //public List<Product> Retrive()
        //{
        //    return new List<Product>();
        //}
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (Current_price == null) isValid = false;
            return isValid;
        }
        //public bool Save()
        //{
        //    return true;
        //}
       

     } 

}
