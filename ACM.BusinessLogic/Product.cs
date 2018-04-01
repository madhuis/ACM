using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class Product
    {
        public int _prodID;
        public Product()
        {
            //Default constructor
        }
        
        // Add a constructor with a parameter.

        public Product(int prodID)
        {
            _prodID = prodID;
        }

    }
}
