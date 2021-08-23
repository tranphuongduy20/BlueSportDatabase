using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class OrderDetail
    {
        public string id { get; set; }
        public string orderId { get; set; }
        public string productId { get; set; }
        public int quantity { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
    }
}
