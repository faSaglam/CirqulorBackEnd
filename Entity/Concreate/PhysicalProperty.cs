using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class PhysicalProperty
    {
        public int PhysicalPropertyID { get; set; }
        public int Density { get; set; }
        public MaterialMetric MaterialMetric { get; set; }
    }
}
