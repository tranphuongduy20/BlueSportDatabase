using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Order
    {
        internal object name;
        internal object image;
        internal object alt;
        internal object text;

        public string id { get; set; }
        public string session { get; set; }
    }
}
