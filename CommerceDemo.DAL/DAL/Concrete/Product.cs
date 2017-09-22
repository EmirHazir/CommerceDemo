using Core.Entities;
using System;
using System.Collections.Generic;

namespace DAL.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DeletedDate { get; set; }

        public decimal Price { get; set; }

        public List<ProductCategory> Categories { get; set; }
    }
}
