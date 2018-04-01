using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class Product
    {
        private int _prodId;
        private string _prodName;
        public Product()
        {
            // Default constructor
        }
        
        // Add a constructor with a parameter.
        public Product(int ID, string pName){
            
            _prodId = ID; 
            _prodName = pName; 
            
        }

    }
}
