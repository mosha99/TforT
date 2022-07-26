using NUnit.Framework;
using TforT.Controllers;
using TforT.DataBase;
using TforT.Models;
using TforT.Repository;
using TforT.Services;
using System.Linq;
namespace TestProject1
{
    public class UnitTest_User
    {
        UserController _userController;
        UserService _userService;
        UserRep _userRep;


        [SetUp]
        public void Setup()
        {
            BaseContext context = new moqContext();
            //BaseContext context = new realContext();
            _userRep = new UserRep(context);
            _userService = new UserService(_userRep);
            _userController = new UserController(_userService);
        }

        [Test]
        public void TestAdd()
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


            if (!Erorr) Assert.Fail();
        }

        [Test]
        public void TestAdd1()
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


            if (!Erorr) Assert.Fail();
        }

        [Test]
        public void TestAdd2()
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


            if (!Erorr) Assert.Fail();
        }

        [Test]
        public void TestAdd3()
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


            if (!Erorr) Assert.Fail();
        }

        [Test]
        public void TestAdd4()
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


            if (!Erorr) Assert.Fail();
        }

    }
}