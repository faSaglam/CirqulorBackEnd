using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOriginService
    {
        ICollection<Origin> GetAll();
        Origin GetSingleByID(int id);
        Origin GetSingleByName(string id);

        void Add(Origin origin);
        void Update(Origin origin);
        void Delete(Origin origin);
    }
}
