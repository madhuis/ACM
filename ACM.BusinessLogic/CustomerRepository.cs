using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class CustomerRepository
    {

        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "me@gmail.com";
                customer.FirstName = "Jacky";
                customer.LastName = "Smith";
            }
            return customer;
        }

       
        // Retrieves all customers.
      
        public List<Customer> Retrieve()
        {
            // Code that retrieves all customers
            return new List<Customer>();
        }

      
        // Saves the current customer.
        
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
