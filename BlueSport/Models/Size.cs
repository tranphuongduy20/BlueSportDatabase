using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Size : BaseModel
    {
        public List<ProductMapSize> productMapSizes { get; set; }
        public List<SizeMapColor> sizeMapColors { get; set; }
    }
}
