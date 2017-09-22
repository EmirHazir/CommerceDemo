﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete
{
   public class ProductCategory
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}