using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class Order
    {

        public Order() { }

        public  Order(int OrderID)
        {

        }

        public int OrderID { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        // Retrieve the order
        public Order Retrieve(int orderID)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;

                
        }





    }
}
