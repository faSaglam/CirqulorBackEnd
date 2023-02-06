using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlantService
    {
        ICollection<Plant> GetAll();
        Plant GetSingleByID(int id);
       

        void Add(Plant plant);
        void Update(Plant plant);
        void Delete(Plant plant);
    }
}
