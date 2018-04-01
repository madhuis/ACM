using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    public class Customer
    {

        public Customer()
        {

                
        }

        public Customer(int custID)
        {
            this.CustomerID = custID;
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

        //Auto-Implement properties
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerID { get; private set; }

        public string FullName
        {

            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }

                    fullname += FirstName;
                }
                return fullname;
            }
           
        }


        public static int instanceCount { get; set; }

        // methods
        /*
         * 1. Saves the current customer
         * 2. Retrive the customers - we used the method overloading concepts.
         * 
         */ 
        public bool save()
        {
            // we are going to define the code little letter.
            return true; 
        }

        public Customer Retrieve(int customerID)
        {
            // Code will be added later
            return new Customer(); 
        }

        public List<Customer> Retrieve()
        {
            // Code will be added later
            return new List<Customer>();
        }
        public bool validate()
        {

            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;

        }





    }
}
