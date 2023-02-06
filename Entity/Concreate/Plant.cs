using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Plant:IEntity
    {
        public int PlantID { get; set; }    
        public string PlantName { get; set;}
        public int FormID { get; set;}
        public Form Form { get; set;}

        public MaterialMetric? MaterialMetric { get; set;}

        public int? PlantOfMaterialMetricID { get; set;}

    }
}
