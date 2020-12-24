﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class Role
    {

        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string RoleName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
