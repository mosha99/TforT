using TforT.DataBase;
using TforT.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TforT.Repository
{
    public class UserRep
    {
        BaseContext _Context;
        public UserRep(BaseContext context)
        {
            _Context = context;
        }

        public List<User> GetUser()
        {
            var users = _Context.users.ToList();
            return users;
        }

        public User GetUser(int userId)
        {
            var user = _Context.users.Single(x => x.UserId == userId);
            return user;
        }

        public void add(User user)
        {
            _Context.users.Add(user);
            _Context.SaveChanges();
        }
        public void Edit(User user)
        {
            var data = _Context.users.FirstOrDefault(x => x.UserId == user.UserId);
            data.Name = user.Name;
            data.Email = user.Email;
            data.Password = user.Password;

            _Context.SaveChanges();
        }
        public void Delete(int userId)
        {
            var entity = _Context.users.Single(x => x.UserId == userId);
            _Context.users.Remove(entity);
            _Context.SaveChanges();
        }
    }
}
