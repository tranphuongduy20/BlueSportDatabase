using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Color : BaseModel
    {
        public List<SizeMapColor> sizeMapColors { get; set; }
    }
}
