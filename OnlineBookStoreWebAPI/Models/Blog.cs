using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string BlogTitle { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string BlogDesc { get; set; }

        public int ViewCount { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }


    }
}
