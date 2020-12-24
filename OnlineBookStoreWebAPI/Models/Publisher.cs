using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Publisher
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string PublisherName { get; set; }
        [Column(TypeName = "nvarchar (100)")]
        public string PublisherCode { get; set; }
        [Column(TypeName = "nvarchar (100)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar (50)")]
        public string Phone { get; set; }

        public ICollection<PublisherProducts> Products { get; set; }


    }
}
