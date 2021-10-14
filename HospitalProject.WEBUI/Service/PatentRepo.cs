using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Infastructure;
using HospitalProject.WEBUI.Data;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Service
{
    public class PatentRepo : IPatentInformation
    {

        private PatentContext _context;

        public PatentRepo(PatentContext context)
        {
            _context = context;
        }

        public void Delete(PatentInformation ppp)
        {
            _context.Patents.Remove(ppp);
        }

      

        public List<PatentInformation> GetAll()
        {
            return _context.Patents.ToList();
        }

       

        public void Insert(PatentInformation p)
        {
            _context.Patents.Add(p);
        }

      
        public void save()
        {
            _context.SaveChanges();
        }

        public void Update(PatentInformation pp)
        {
            _context.Patents.Update(pp);
        }

               
        
    }
}
