using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Category : BaseModel
    {
        public int level { get; set; }
        public string parentId { get; set; }
        public string slug { get; set; }
        public List<ProductMapCate> productMapCates { get; set; }
    }
}
