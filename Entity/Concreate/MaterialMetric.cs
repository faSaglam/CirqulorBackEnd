using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class MaterialMetric : IEntity
    {
        public int MaterialMetricID { get; set; } 
        

        public string? Notes { get; set; }

        //public ICollection<Vendor> Vendors { get; set; }

        public MechanicalProperty? MechanicalProperty { get; set; }

        public int? MechanicalPropertyID { get; set; }

        public PhysicalProperty? PhysicalProperty { get; set; }
        public int? PhysicalPropertyID { get; set; }

        public ElectricalProperty? ElectricalProperty { get;set; }
        public int? ElectricalPropertyID { get; set; }
        public ThermalProperty? ThermalProperty { get; set;}
        public int? ThermalPropertyID { get; set; }
        public OpticalProperty? OpticalProperty { get; set; }
        public int? OpticalPropertyID { get; set; }
        public Plant Plant { get; set; }

   
    }
}
