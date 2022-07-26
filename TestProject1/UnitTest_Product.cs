using NUnit.Framework;
using TforT.Controllers;
using TforT.DataBase;
using TforT.Models;
using TforT.Repository;
using TforT.Services;
using System.Linq;

namespace TestProject1
{
    public class UnitTest_Product
    {
        ProductController _ProductController;
        ProductService _ProductService;
        ProductRep _ProductRep;

        [SetUp]
        public void Setup()
        {
            BaseContext context = new moqContext();
            _ProductRep = new ProductRep(context);
            _ProductService = new ProductService(_ProductRep);
            _ProductController = new ProductController(_ProductService);
        }

        [Test]
        public void TestAdd()
        {
            bool Erorr = true;

            var product = new Product()
            {
                Title = "معین",
                Price = 1500/98
            };

            var result1 = _ProductController.Get().Count;
            Erorr = Erorr && result1 == 0;

            var result2 = _ProductController.Post(product);
            Erorr = Erorr && result2 == true;

            int id = _ProductController.Get().Single(x => x.Title == product.Title).ProductId;
            Erorr = Erorr && id > 0;

            string title = _ProductController.Get(id).Title;
            Erorr = Erorr && title == product.Title;


            if (Erorr) Assert.Pass();
            Assert.Fail();
        }
    }
}
