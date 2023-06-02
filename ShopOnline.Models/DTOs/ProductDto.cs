using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.DTOs
{
    public class ProductDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public string? ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
    }
}
