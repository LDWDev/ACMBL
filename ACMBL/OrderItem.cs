using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemID)
        {
            this.OrderItemID = orderItemID;
        }

        public int OrderItemID { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemID)
        {
            //retrieve an order
            return new OrderItem(orderItemID);
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity <=0||PurchasePrice==null||ProductID<=0) { isValid = false; }
            return isValid;
        }
    }
}
