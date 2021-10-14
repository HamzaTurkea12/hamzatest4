using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Infastructure;
using HospitalProject.WEBUI.Data;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Service
{
    public class UserRepo : IUser
    {
        private UserContext _context;
        public UserRepo(UserContext context)
        {
            _context = context;
        }

        public void Delete(UserCreateModel uu)
        {
            _context.Users.Remove(uu);

        }

        public List<UserCreateModel> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Insert(UserCreateModel user)
        {
            _context.Users.Add(user);
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public void Update(UserCreateModel u)
        {
            _context.Users.Update(u);
        }
    }
}
