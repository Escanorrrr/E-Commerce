using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.EntityFramework;

public class EfUserDal:EfEntityRepositoryBase<User, ShoppingContext>, IUserDal
{
    
}