using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string CustomerName { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar (25)")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
