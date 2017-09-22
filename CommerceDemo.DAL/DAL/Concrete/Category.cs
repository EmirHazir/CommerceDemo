using Core.Entities;
using System.Collections.Generic;

namespace DAL.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

    
        public List<ProductCategory> Products { get; set; }

    }
}
