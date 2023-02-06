using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Origin:IEntity
    {
        public int OriginID { get; set; }
        public string OriginName { get; set;}

        public int DefinationID { get; set; }

        public Definition Definition { get; set; }

        public ICollection<Form> Forms { get; set; }
    }
}
