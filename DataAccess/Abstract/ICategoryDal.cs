using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface ICategoryDal:IEntityRepository<Category>
{
   // List<OperationClaim> GetClaims(User user);
   
}