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
