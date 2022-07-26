using System.Collections.Generic;
using TforT.Models;
using TforT.Repository;

namespace TforT.Services
{
    public class ProductService
    {
        ProductRep _productRep;
        public ProductService(ProductRep productRep)
        {
            _productRep = productRep;
        }

        public List<Product> Getproduct()
        {
            try
            {
                var result = _productRep.Getproduct();
                return result;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public Product Getproduct(int productId)
        {
            try
            {
                var product = _productRep.Getproduct(productId);
                return product;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public bool add(Product product)
        {
            try
            {
                _productRep.add(product);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Edit(Product product)
        {
            try
            {
                _productRep.Edit(product);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(int productId)
        {
            try
            {
                _productRep.Delete(productId);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
