using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class Order
    {
        public Order() { }
        public Order(int orderID) { this.OrderID = orderID; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public bool Validate()
        {
            //check an order is valid

            var isValid = true;
            if (this.OrderDate == null) { isValid = false; }
            return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " ("+OrderID+") ";
        }
    }
}
