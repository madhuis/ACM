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

        public int ProductID { get; private set; }

        public decimal? currentPrice { get; set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }

        public bool save()
        {
            // we are going to define the code little letter.
            return true;
        }

        public Product Retrieve(int ProdID)
        {
            // Code will be added later
            return new Product();
        }

        public List<Product> Retrieve()
        {
            // Code will be added later
            return new List<Product>();
        }
        public bool validate()
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
