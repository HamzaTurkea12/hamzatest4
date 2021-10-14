using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Infastructure;
using HospitalProject.WEBUI.Data;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Service
{
    public class SpeccimenRepo : ISpecimenanddiseaseinformation
    {
        private Specimenan _context;

        public SpeccimenRepo(Specimenan context)
        {
            _context = context;
        }

        public void Delete(Specimenanddiseaseinformation ppp)
        {
            _context.Specimenand.Remove(ppp);
        }

       

        public List<Specimenanddiseaseinformation> GetAll()
        {
            return _context.Specimenand.ToList();
        }

       
        public void Insert(Specimenanddiseaseinformation p)
        {
            _context.Specimenand.Add(p);
        }

        
        public void save()
        {
            _context.SaveChanges();
        }

        public void Update(Specimenanddiseaseinformation pp)
        {
            _context.Specimenand.Update(pp);
        }

       
        
    }
}
