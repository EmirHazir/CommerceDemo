using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
   public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int catId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int prductId);

    }
}
