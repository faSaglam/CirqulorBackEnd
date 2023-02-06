using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Form:IEntity
    {

        public int FormID { get; set; }
        public string FormName { get; set; }

        public int OriginID { get; set; }

        public Origin Origin { get; set; }

        public ICollection<Plant> Plants { get; set; }
    }
}
