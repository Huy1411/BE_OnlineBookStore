using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string CategoryName { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string CategoryCode { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string CategoryDesc { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
