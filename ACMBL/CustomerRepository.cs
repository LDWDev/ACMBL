using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {           
        addressRepository= new AddressRepository();
        }
        public List<Customer> Retrieve()
        {
            //retrieves all customers
            return new List<Customer>();
        }
        public Customer Retrieve(int id)
        {
            //retrieves a specific customer by ID
            Customer customer = new Customer(id);
            customer.AddressList = addressRepository.RetrieveByCustomerId(id).ToList();

            //temporary hard-coded customer for testing
            if (id == 1)
            {
                customer.EmailAddress = "abc@def.com";
                customer.FirstName = "abc";
                customer.LastName = "def";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            //saves the customer data
            return true;
        }
    }
}
