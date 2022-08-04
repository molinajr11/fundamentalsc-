using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer
{
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemId)
        {
            orderItemId = orderItemId;
        }

        public int orderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PruchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrive(int OrderItemId) => new OrderItem();

        public bool Save() {return true;}
        public bool Validate()
        {
            var isValid = true;
            if(Quantity<=0)isValid = false;
            if(ProductId<=0)isValid = false;
            if(PruchasePrice==null)isValid = false;
            return isValid;
        }

    }
}
