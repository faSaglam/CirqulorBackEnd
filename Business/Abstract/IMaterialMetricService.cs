using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMaterialMetricService
    {
        ICollection<MaterialMetric> GetAll();
        MaterialMetric GetSingleByID(int id);


        void Add(MaterialMetric materialMetric);
        void Update(MaterialMetric materialMetric);
        void Delete(MaterialMetric materialMetric);
    }
}
