using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Dtos.Dtos
{
    public class UserDtos
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Admin { get; set; }
    }
}
