using Core.Entities;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Metarial:IEntity
    {
        public int MetarialID { get; set; }  

        public string MetarialName { get; set;}

        public int TaxonomyID { get; set; } 
        public Taxonomy Taxonomy { get; set; }

        public ICollection<Definition> Definitions { get; set; }
       
    }
}
