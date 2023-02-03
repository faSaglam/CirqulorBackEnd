using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDefinitionService
    {
        ICollection<Definition> GetAll();
        Definition GetSingleByID(int id);
        Definition GetSingleByName(string id);

        void Add(Definition definition);
        void Update(Definition definition);
        void Delete(Definition definition);
    }
}
