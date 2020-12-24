using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class PublisherProducts
    {

        [Key]
        public int ID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
