using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UserManager:IUserService
{
    IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public void Add(User user)
    {
        _userDal.Add(user);
    }

    public User GetByMail(string email)
    {
        return _userDal.Get(u => u.Email == email);
    }
}