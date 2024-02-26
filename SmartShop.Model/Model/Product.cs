using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Model.Model
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int ProductQuantity { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<OrdersItems> OrdersItems { get; set; }



    }
}
