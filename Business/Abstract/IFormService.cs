using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFormService
    {
        ICollection<Form> GetAll();
        Form GetSingleByID(int id);
        Form GetSingleByName(string id);

        void Add(Form form);
        void Update(Form form);
        void Delete(Form form);
    }
}
