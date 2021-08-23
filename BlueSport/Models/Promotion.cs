using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Promotion : BaseModel
    {
        public string productId { get; set; }
        public Product product { get; set; }
        public List<PromotionDetail> promotionDetails { get; set; }
    }
}
