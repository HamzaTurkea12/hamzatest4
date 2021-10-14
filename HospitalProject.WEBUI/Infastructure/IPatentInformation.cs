using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Infastructure
{
    public interface IPatentInformation
    {
         List<PatentInformation> GetAll();

       
        void save();
        void Insert(PatentInformation patent);
        void Delete(PatentInformation pp);
        void Update(PatentInformation p);
    }
}
