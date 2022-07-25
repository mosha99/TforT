using System.Collections.Generic;
using TforT.Models;
using TforT.Repository;

namespace TforT.Services
{
    public class UserService
    {
        UserRep _userRep;
        public UserService(UserRep userRep)
        {
            _userRep = userRep;
        }

        public List<User> GetUser()
        {
            try
            {
                var result = _userRep.GetUser();
                return result;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public User GetUser(int userId)
        {
            try
            {
                var user = _userRep.GetUser(userId);
                return user;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public bool add(User user)
        {
            try
            {
                _userRep.add(user);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Edit(User user)
        {
            try
            {
                _userRep.Edit(user);
                return true ;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(int userId)
        {
            try
            {
                _userRep.Delete(userId);
                return true ;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
