using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLogic
{
    class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            
            // Temporary hard coded values to return 
            // a populated order
            if (orderId == 10)
            {


        /*
        public DateTimeOffset(DateTime dateTime);
        public DateTimeOffset(long ticks, TimeSpan offset);
        public DateTimeOffset(DateTime dateTime, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset);
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset);
                 * 
                 */
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

    
        // Saves the current order.
        public bool Save()
        {
            // Code that saves the defined order
            return true;
        }
    }
}
