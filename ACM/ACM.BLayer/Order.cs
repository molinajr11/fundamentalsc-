﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            orderId = orderId;
        }
        public int orderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order Retrive(int orderId) => new Order();

        public bool Save() { return true; }

        public bool Validate()
        {
            var isValid = true;

           if(OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
