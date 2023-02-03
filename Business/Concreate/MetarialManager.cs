using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class MetarialManager : IMetarialService
    {
        private readonly IMetarialDal _metarialDal;
        public MetarialManager(IMetarialDal metarialDal)
        {
            _metarialDal = metarialDal;
        }
        public void Add(Metarial metarial)
        {
            _metarialDal.Add(metarial);
        }

        public void Delete(Metarial metarial)
        {
            _metarialDal.Delete(metarial);
        }

        public ICollection<Metarial> GetAll()
        {
            return _metarialDal.GetAll();
        }

        public Metarial GetSingleSubCategory(int id)
        {
           return _metarialDal.Get(filter:s=>s.MetarialID== id);
        }

        public Metarial GetSingleSubCategory(string id)
        {
          return _metarialDal.Get(filter:s=>s.MetarialName== id);
        }

        public void Update(Metarial metarial)
        {
            _metarialDal.Update(metarial);
        }
    }
}
