using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Product
    {

        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string ProductName { get; set; }

        [Column(TypeName = "nvarchar (10)")]
        public string ProductCode { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Quantity { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Price { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Status { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<OrderProducts> Orders { get; set; }
    }
}
