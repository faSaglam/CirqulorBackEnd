using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class ThermalProperty:IEntity
    {
        public int ThermalPropertyID { get; set; }  
        public int? CTE { get; set; }
        public int? SpecificHeatCapacity { get; set; }
        public int? SofteningPoint { get; set; }

        public MaterialMetric MaterialMetric { get; set; }
    }
}
