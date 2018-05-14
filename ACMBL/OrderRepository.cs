using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderID)
        { //retrieve one order from ID
           var order= new Order(orderID);
            //temp hardcoded values to test retrieval
            if (orderID == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 1, 1, 0, 0, 0, new TimeSpan(0,0,0));
            }
            return order;
        }

        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges && product.isValid)
            {
                if (product.IsNew)
                {
                    //call an insertion for new product
                }
                else
                {
                    //call an update for the product
                }
            }
            else
            {
                success = false;
            }
            //save an order
            return success;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            //this would retrieve code, but we will use hard-coded values
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();
            //code that retrives the order items to display
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }

                return orderDisplay;
        }
    }
}
