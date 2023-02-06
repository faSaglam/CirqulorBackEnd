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
    public class PlantManager : IPlantService

    {
        private readonly IPlantDal _plantDal;
        public PlantManager(IPlantDal plantDal)
        {
            _plantDal = plantDal;
        }

        public void Add(Plant plant)
        {
            _plantDal.Add(plant);
        }

        public void Delete(Plant plant)
        {
            _plantDal.Delete(plant);
        }

        public ICollection<Plant> GetAll()
        {
            return _plantDal.GetAll();
        }

        public Plant GetSingleByID(int id)
        {
            return _plantDal.Get(filter:p=>p.PlantID== id);
        }

        public void Update(Plant plant)
        {
            _plantDal.Update(plant);
        }
    }
}
