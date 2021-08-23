using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class Product : BaseModel
    {
        public string slug { get; set; }
        public int priceCurrent { get; set; }
        public decimal priceOld { get; set; }
        public decimal saleOff { get; set; }
        public string description { get; set; }
        public string brandId { get; set; }
        public bool isSoldOut { get; set; }
        public int installment { get; set; }
        public Brand brand { get; set; }
        public List<Promotion> promotions { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<ProductDetail> productDetails { get; set; }
        public List<ProductMapSize> productMapSizes { get; set; }
        public List<ProductMapCate> productMapCates { get; set; }
    }
}
