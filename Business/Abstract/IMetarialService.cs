using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMetarialService
    {
        ICollection<Metarial> GetAll();
        Metarial GetSingleSubCategory(int id);
        Metarial GetSingleSubCategory(string id);

        void Add(Metarial metarial);
        void Update(Metarial metarial);
        void Delete(Metarial metarial);
    }
}
