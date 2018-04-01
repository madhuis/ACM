using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class Product
    {
        public Product()
        {
            // Default constructor
        }
        
        // Add a constructor with a parameter.
        public Product(int prodID){

            ProductID = prodID;
            
        }
        
        // Add some more methods here.

        public int ProductID { get; private set; }

        public decimal? currentPrice { get; set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }

      
        public bool Validate()
        {

            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (currentPrice == null)
            {
                isValid = false;    
            }

            return isValid;

        }
    }
}
