using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class ProductMapCate
    {
        public string productId { get; set; }
        public string cateId { get; set; }
        public Product product { get; set; }
        public Category category { get; set; }
    }
}
