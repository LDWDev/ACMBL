using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class ProductRepository
    {
        public Product Retrieve()
        {
            //implement code to retrieve all products

            return new Product();
        }

        public Product Retrieve(int productId)
        {
            //implement code to retrieve specific product

            var product = new Product(productId);
            Object myObject = new Object();
            Console.WriteLine("Object: "+myObject.ToString());
            //hardcoded values to test this code
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted sizes";
                product.CurrentPrice = 15.96M;
            }
            Console.WriteLine("Product: " + product.ToString());
            return product;
        }

        public bool Save()
        {
            //implement a save confirmation

            return true;
        }
    }
}
