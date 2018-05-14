using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;
namespace ACMBL
{
    public class Customer :EntityBase, ILoggable
    {
        public Customer() :this(0)
        {
            ////this code below is copy pasted code so we shouldn't use it. Instead we use CONSTRUCTOR CHAINING
           // AddressList = new List<Address>(); //instantiate so we have an empty list instead of null 
           ////
        }
        public Customer(int id)
        {
            CustomerId = id;
            AddressList = new List<Address>(); //instantiate so we have an empty list instead of null
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        // private string _firstName;

        public int CustomerType { get; set; }
        public string FirstName {get; set;}
        public static int InstanceCount { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string PostalAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FullName
        {
            get
            {
                return LastName +", "+ FirstName;
            }
        }

        public override bool Validate()
        {
            bool isValid = !(String.IsNullOrWhiteSpace(this.EmailAddress) || String.IsNullOrWhiteSpace(this.FullName)); //check if a field is null or whitespace
            return isValid;
        }
        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logResult = "Customer name: " + FullName + "\n" + "Order status: " + this.EntityState.ToString();
            return logResult;
        }
    }
}
