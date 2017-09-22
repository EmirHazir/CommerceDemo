using BLL.Interfaces;
using System;
using System.Collections.Generic;
using DAL.Concrete;
using DAL.Abstracts;

namespace BLL.EFEntities
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDal;

        public ProductManager(IProductDAL productDAL)
        {
            this._productDal = productDAL;
        }


        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int prductId)
        {
            _productDal.Delete( new Product {Id = prductId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int catId)
        {
            return _productDal.GetList(x => x.Id == catId || catId == 0);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
