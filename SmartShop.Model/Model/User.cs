using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Model.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [MaxLength(11)]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        [DefaultValue(false)]
        public bool Admin { get; set; }
        public ICollection<Order> Orders { get; set; }



    }
}
