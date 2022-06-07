using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IUserService
{
        // List<OpertaionClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string mail);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        IResult Update(User user);
        IResult Delete(User user);
}
   