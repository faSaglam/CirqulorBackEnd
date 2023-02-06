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
    public class MaterialMetricManager : IMaterialMetricService
    {
        private readonly IMaterialMetricDal _materialMetricDal;
        public MaterialMetricManager(IMaterialMetricDal materialMetricDal)
        {
            _materialMetricDal= materialMetricDal;
        }
        public void Add(MaterialMetric materialMetric)
        {
            _materialMetricDal.Add(materialMetric);
        }

        public void Delete(MaterialMetric materialMetric)
        {
            _materialMetricDal.Delete(materialMetric);
        }

        public ICollection<MaterialMetric> GetAll()
        {
            return _materialMetricDal.GetAll();
        }

        public MaterialMetric GetSingleByID(int id)
        {
            return _materialMetricDal.Get(filter:mm=>mm.MaterialMetricID== id);
        }

        public void Update(MaterialMetric materialMetric)
        {
           _materialMetricDal.Update(materialMetric);
        }
    }
}
