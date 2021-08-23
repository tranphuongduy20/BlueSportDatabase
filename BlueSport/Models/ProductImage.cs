using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class ProductImage
    {
        public string id { get; set; }
        public string productId { get; set; }
        public string path { get; set; }
        public string alt { get; set; }
        public Product product { get; set; }
    }
}
