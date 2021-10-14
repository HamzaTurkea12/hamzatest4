using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Infastructure
{
    public interface ISpecimenanddiseaseinformation
    {
        List<Specimenanddiseaseinformation> GetAll();

      
        void Insert(Specimenanddiseaseinformation p);

        void Update(Specimenanddiseaseinformation pp);
        void Delete(Specimenanddiseaseinformation ppp);

        void save();
    }
}
