using Core.EntityFramework;
using DAL.Abstracts;
using DAL.ContextFiles;
using DAL.Concrete;

namespace DAL.EntityDAL
{
    public class EfCategoryDAL : EfEntityRepositoryBase<Category, CommerceAppContext>, ICategoryDAL
    {
    }
}
