using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class TaxonomyManager : ITaxonomyService
    {
        private readonly ITaxonomyDal _taxonomyDal;

        public TaxonomyManager(ITaxonomyDal taxonomyDal)
        {
            _taxonomyDal=taxonomyDal;
        }

        public void Add(Taxonomy taxonomy)
        {
            _taxonomyDal.Add(taxonomy);
        }

        public void Delete(Taxonomy taxonomy)
        {
            _taxonomyDal.Delete(taxonomy);
        }

        public void Update(Taxonomy taxonomy)
        {
            _taxonomyDal.Update(taxonomy);
        }

        ICollection<Taxonomy> ITaxonomyService.GetAll()
        {
           return _taxonomyDal.GetAll();
        }

        Taxonomy ITaxonomyService.GetSingleCategory(int id)
        {
            return _taxonomyDal.Get(filter:c=>c.TaxonomyID== id);
        }
        Taxonomy ITaxonomyService.GetSingleCategory(string id)
        {
            return _taxonomyDal.Get(filter: c => c.TaxonomyName == id);
        }
    }
}
