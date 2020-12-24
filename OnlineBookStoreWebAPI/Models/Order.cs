using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string OrderName { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Status { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public ICollection<OrderProducts> Products { get; set; }

    }
}
