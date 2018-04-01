using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            
            Product product = new Product(productId);
            
            // Temporary check.
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.currentPrice = 15.96M;
            }
            return product;
        }

        
        // Saves the current product.
     
        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
    }
}
