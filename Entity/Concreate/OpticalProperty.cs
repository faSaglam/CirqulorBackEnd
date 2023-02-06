using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class OpticalProperty : IEntity
    {
        public int OpticalPropertyID { get; set; }
        public int? RefractiveIndex { get; set; }
        public MaterialMetric MaterialMetric { get; set; }
    }
}
