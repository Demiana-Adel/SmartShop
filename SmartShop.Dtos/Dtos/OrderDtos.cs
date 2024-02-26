using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Dtos.Dtos
{
    public class OrderDtos
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Order_Status { get; set; } = "Processing";
        public int UserID { get; set; }
        public List<OrdersItemsDtos> Items { get; set; }
    }
}
