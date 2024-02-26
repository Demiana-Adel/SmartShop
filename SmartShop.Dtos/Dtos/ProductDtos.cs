using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Dtos.Dtos
{
    public class ProductDtos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int ProductQuantity { get; set; }
        public int CategoryID { get; set; }
    }
}
