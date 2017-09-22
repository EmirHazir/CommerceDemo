using Core.EntityFramework;
using DAL.Abstracts;
using DAL.ContextFiles;
using DAL.Concrete;

namespace DAL.EntityDAL
{
    public class EfProductDAL : EfEntityRepositoryBase<Product, CommerceAppContext>, IProductDAL
    {
    }
}
