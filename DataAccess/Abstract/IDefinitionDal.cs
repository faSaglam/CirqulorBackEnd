using Core.DataAccess;
using Core.Entities;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDefinitionDal: IEntityReposityory<Definition>
    {
    }
}
