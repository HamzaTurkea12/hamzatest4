using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Infastructure
{
    public interface IUser
    {
        List<UserCreateModel> GetAll();


        void save();
        void Insert(UserCreateModel user);
        void Delete(UserCreateModel uu);
        void Update(UserCreateModel u);
    }
}
