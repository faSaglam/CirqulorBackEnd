using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int ProductID);

        Product GetProduct(string ProductName);
        ICollection<Product> GetListBySub(int SubcategoryID);
      
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
