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
    public class DefinitionManager : IDefinitionService
    {
        private readonly IDefinitionDal _definitionDal;
        public DefinitionManager(IDefinitionDal definitionDal)
        {
            _definitionDal = definitionDal;
        }
        public void Add(Definition definition)
        {
            _definitionDal.Add(definition);
        }

        public void Delete(Definition definition)
        {
            _definitionDal.Delete(definition);
        }

        public ICollection<Definition> GetAll()
        {
            return _definitionDal.GetAll();
        }

        public Definition GetSingleByID(int id)
        {
            return _definitionDal.Get(filter:x=>x.DefinitionID ==id);
        }

        public Definition GetSingleByName(string id)
        {
            return _definitionDal.Get(filter:x=>x.DefinitionName ==id);
        }

        public void Update(Definition definition)
        {
            _definitionDal.Update(definition);
        }
    }
}
