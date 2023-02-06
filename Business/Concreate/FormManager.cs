using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class FormManager : IFormService
    {
        private readonly IFormDal _formDal;
        public FormManager(IFormDal formDal) 
        {
            _formDal = formDal;
        }
        public void Add(Form form)
        {
            _formDal.Add(form);
        }

        public void Delete(Form form)
        {
           _formDal.Delete(form);
        }

        public ICollection<Form> GetAll()
        {
            return _formDal.GetAll();
        }

        public Form GetSingleByID(int id)
        {
            return _formDal.Get(filter:x=>x.FormID== id);
        }

        public Form GetSingleByName(string id)
        {
            return _formDal.Get(filter: x => x.FormName == id);
        }

        public void Update(Form form)
        {
            _formDal.Update(form);
        }
    }
}
