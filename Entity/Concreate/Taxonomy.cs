using Core.Entities;
using Entities.Concreate;

namespace Entitites.Concrete
{
    public class Taxonomy : IEntity
    {
        public int TaxonomyID { get; set; }
        public string TaxonomyName { get; set; }

        public ICollection<Metarial> Metarial { get; set; } //one-to-many

       
    }
}
