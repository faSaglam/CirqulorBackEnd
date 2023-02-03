using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Definition:IEntity
    {
        public int DefinitionID { get; set; }
        public string DefinitionName { get; set; }

        public int MetarialID { get; set; }

        public Metarial Metarial { get; set; }

        public ICollection<Origin> Origins { get; set; }
    }
}
