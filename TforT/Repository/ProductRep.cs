using TforT.DataBase;
using TforT.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TforT.Repository
{
    public class ProductRep
    {
        BaseContext _Context;
        public ProductRep(BaseContext context)
        {
            _Context = context;
        }

        public List<Product> Getproduct()
        {
            var product = _Context.products.AsNoTracking().ToList();
            return product;
        }

        public Product Getproduct(int productId)
        {
            var product = _Context.products.AsNoTracking().Single(x => x.ProductId == productId);
            return product;
        }

        public void add(Product product)
        {
            _Context.products.Add(product);
            _Context.SaveChanges();
        }
        public void Edit(Product product)
        {
            var data = _Context.products.FirstOrDefault(x => x.ProductId == product.ProductId);
            data.Title = product.Title;
            data.Price = product.Price;

            _Context.SaveChanges();
        }
        public void Delete(int productId)
        {
            var entity = _Context.products.Single(x => x.ProductId == productId);
            _Context.products.Remove(entity);
            _Context.SaveChanges();
        }
    }
}
