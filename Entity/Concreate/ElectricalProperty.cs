using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class ElectricalProperty:IEntity
    {
        public int ElectricalPropertyID { get; set; }   
        public int? ElectricalResistivity { get; set; }
        public int? DielectricConstant { get; set; }
        public MaterialMetric MaterialMetric { get; set; }


    }
}
