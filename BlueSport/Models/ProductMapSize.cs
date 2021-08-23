using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class ProductMapSize
    {
        public string productId { get; set; }
        public string sizeId { get; set; }
        public Product product { get; set; }
        public Size size { get; set; }
    }
}
