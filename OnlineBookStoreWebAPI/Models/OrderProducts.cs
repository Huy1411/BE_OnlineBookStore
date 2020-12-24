using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class OrderProducts
    {
        [Key]
        public int ID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

        public decimal Total_Price { get; set; }
        public int Total_Qty { get; set; }
    }
}
