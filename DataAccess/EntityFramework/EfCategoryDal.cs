using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.EntityFramework;

public class EfCategoryDal:EfEntityRepositoryBase<Category, ShoppingContext>, ICategoryDal
{
    
}