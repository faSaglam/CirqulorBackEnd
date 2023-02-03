using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITaxonomyService
    {
     
        ICollection<Taxonomy> GetAll();
        Taxonomy GetSingleCategory(int id);
        Taxonomy GetSingleCategory(string id);

        void Add(Taxonomy taxonomy);    
        void Update(Taxonomy taxonomy);
        void Delete(Taxonomy taxonomy);
    }
}
