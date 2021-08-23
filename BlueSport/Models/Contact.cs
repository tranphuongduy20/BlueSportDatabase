using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Contact
    {
        public string id { get; set; }
        public string topicId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string cusName { get; set; }
        public string cusEmail { get; set; }
        public string cusPhone { get; set; }
        public Topic topic { get; set; }
    }
}
