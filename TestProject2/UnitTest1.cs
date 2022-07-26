using System;
using System.Linq;
using TforT.Controllers;
using TforT.DataBase;
using TforT.Models;
using TforT.Repository;
using TforT.Services;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        UserController _userController;
        UserService _userService;
        UserRep _userRep;
        public UnitTest1()
        {

            BaseContext context = new moqContext();
            //BaseContext context = new realContext();
            _userRep = new UserRep(context);
            _userService = new UserService(_userRep);
            _userController = new UserController(_userService);
        }

        [Fact]
        public void Test1()
        {
            bool Erorr = true;

            var user = new User()
            {
                Name = "معین",
                UserName = "moein"
            };

            var result1 = _userController.Get().Count;
            Erorr = Erorr && result1 == 0;

            var result2 = _userController.Post(user);
            Erorr = Erorr && result2 == true;

            int id = _userController.Get().Single(x => x.UserName == user.UserName).UserId;
            Erorr = Erorr && id > 0;

            string username = _userController.Get(id).UserName;
            Erorr = Erorr && username == user.UserName;


            if (!Erorr) Assert.True(false);
        }

        [Fact]
        public void Test3()
        {
            bool Erorr = true;

            var user = new User()
            {
                Name = "معین",
                UserName = "moein"
            };

            var result1 = _userController.Get().Count;
            Erorr = Erorr && result1 == 0;

            var result2 = _userController.Post(user);
            Erorr = Erorr && result2 == true;

            int id = _userController.Get().Single(x => x.UserName == user.UserName).UserId;
            Erorr = Erorr && id > 0;

            string username = _userController.Get(id).UserName;
            Erorr = Erorr && username == user.UserName;


            if (!Erorr) Assert.True(false);
        }

        [Fact]
        public void Test2()
        {
            bool Erorr = true;

            var user = new User()
            {
                Name = "معین",
                UserName = "moein"
            };

            var result1 = _userController.Get().Count;
            Erorr = Erorr && result1 == 0;

            var result2 = _userController.Post(user);
            Erorr = Erorr && result2 == true;

            int id = _userController.Get().Single(x => x.UserName == user.UserName).UserId;
            Erorr = Erorr && id > 0;

            string username = _userController.Get(id).UserName;
            Erorr = Erorr && username == user.UserName;


            if (!Erorr) Assert.True(false);
        }

        [Fact]
        public void Test4()
        {
            bool Erorr = true;

            var user = new User()
            {
                Name = "معین",
                UserName = "moein"
            };

            var result1 = _userController.Get().Count;
            Erorr = Erorr && result1 == 0;

            var result2 = _userController.Post(user);
            Erorr = Erorr && result2 == true;

            int id = _userController.Get().Single(x => x.UserName == user.UserName).UserId;
            Erorr = Erorr && id > 0;

            string username = _userController.Get(id).UserName;
            Erorr = Erorr && username == user.UserName;


            if (!Erorr) Assert.True(false);
        }
    }
}
