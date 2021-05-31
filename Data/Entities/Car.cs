﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Car : BaseEntity
    {
        [Required]
        [MaxLength(80)]
        public string Model { get; set; }

        [Required]
        [MaxLength(10)]
        public string Condition { get; set; }

        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        [Required]
        public int Power { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
    }
}
