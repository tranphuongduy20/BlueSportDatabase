using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Banner : BaseModel
    {
        public string image { get; set; }
        public string alt { get; set; }
        public string typeId { get; set; }
        public string text { get; set; }
        public BannerType type { get; set; }
    }
}
