using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Concrete
{
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

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<List<ParasutUserDto>> GetParasutUser()
        {
            return new SuccessDataResult<List<ParasutUserDto>>(_userDal.GetParasutUser());
        }

        public IDataResult<List<TrendyolUserDto>> GetTrendyolUser()
        {
            return new SuccessDataResult<List<TrendyolUserDto>>(_userDal.GetTrendyolUser());
        }
    }
}
