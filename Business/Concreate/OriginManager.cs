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
    public class OriginManager : IOriginService
    {
        private readonly IOriginDal _originDal;

        public OriginManager(IOriginDal originDal)
        {
            _originDal = originDal;
        }

        public void Add(Origin origin)
        {
            _originDal.Add(origin);
        }

        public void Delete(Origin origin)
        {
          _originDal.Delete(origin);
        }

        public ICollection<Origin> GetAll()
        {
            return _originDal.GetAll();
        }

        public Origin GetSingleByID(int id)
        {
            return _originDal.Get(filter: o => o.OriginID == id);
        }

        public Origin GetSingleByName(string id)
        {
            return _originDal.Get(filter: o => o.OriginName == id);
        }

        public void Update(Origin origin)
        {
           _originDal.Update(origin);
        }
    }
}
