﻿using MVCTutorial6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}