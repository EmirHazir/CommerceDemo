using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetById(int catId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
    }
}