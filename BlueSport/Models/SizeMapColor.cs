using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class SizeMapColor
    {
        public string sizeId { get; set; }
        public string colorId { get; set; }
        public int quantity { get; set; }
        public Size size { get; set; }
        public Color color { get; set; }
    }
}
