using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class OrderItem
    {

        public OrderItem() { }

        public OrderItem(int orderItem)
        {
            this.OrderItemID = orderItem;
        }

        public int OrderItemID { get; private set; }

        public int OrderQuantity { get; set; }

        public int ProductID { get; set; }

        public decimal? PurchasePrice { get; set; }

        // Retrieve the Order Item
        public OrderItem Retrieve()
        {
            return new OrderItem();
        }


        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderQuantity <= 0)
                isValid = false;

            if (ProductID <= 0)
                isValid = false;

            if (PurchasePrice == null)
                isValid = false;

            return isValid;
        }

    }
}
