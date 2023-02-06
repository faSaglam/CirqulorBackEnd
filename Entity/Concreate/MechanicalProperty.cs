using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class MechanicalProperty:IEntity
    {
        public int MechanicalPropertyID { get; set; }
        public int? TensileStr { get; set; }
        public int ? ElongationOfBreak { get; set; }
        public int? ModulusofElasticity { get; set; }

        public int? PoissonsRatio { get; set; }

        public int? ShearModulus { get; set; }

      
        public MaterialMetric MaterialMetric { get; set; }
    }
}
