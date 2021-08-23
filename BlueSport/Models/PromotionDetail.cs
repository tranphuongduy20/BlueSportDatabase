using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class PromotionDetail
    {
        public string id { get; set; }
        public string info { get; set; }
        public bool isOnline { get; set; }
        public bool isMore { get; set; }
        public string promotionId { get; set; }
        public Promotion promotion { get; set; }

    }
}
