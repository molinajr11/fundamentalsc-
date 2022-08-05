using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer
{
    public class Order
    {
        public Order():this(0)
        {

        }
        public Order(int orderId)
        {
            orderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int orderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddresId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public bool Validate()
        {
            var isValid = true;

           if(OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
