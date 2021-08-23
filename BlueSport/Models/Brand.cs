using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Brand : BaseModel
    {
        public string info { get; set; }
        public string img { get; set; }
        public List<Product> products { get; set; }
    }
}
