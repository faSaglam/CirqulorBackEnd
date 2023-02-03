using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int ProductID)
        {
           return _productDal.Get(filter:x=>x.ProductID== ProductID);
        }

        public ICollection<Product> GetListBySub(int SubcategoryID)
        {
            return _productDal.GetAll(filter:x=>x.SubCategoryID== SubcategoryID);
        }

        public Product GetProduct(string ProductName)
        {
            return _productDal.Get(filter: x => x.ProductName == ProductName);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
