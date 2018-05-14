using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        private String _ProductName;

        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }

        public override bool Validate()
        {
            //implement validation code

            var isValid = true;
            if (string.IsNullOrWhiteSpace(this.ProductName)) { isValid = false; }
            if (this.CurrentPrice == null) { isValid = false; }
            return isValid;
        }

    }
}
