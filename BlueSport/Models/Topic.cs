using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Topic : BaseModel
    {
        public List<Contact> contacts { get; set; }
    }
}
