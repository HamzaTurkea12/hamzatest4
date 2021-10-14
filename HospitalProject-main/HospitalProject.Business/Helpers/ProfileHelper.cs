using AutoMapper;
using HospitalProject.Business.Mappings.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Helpers
{
	public static class ProfileHelper
	{
		public static List<Profile> GetProfiles() //POFİLE benim base classım. yani sallıtyorum ADV.profile'ı profile yerine de kullanabilirim
		{//profile benim base classım. Duruma göre değişik profillerı ekleyecepğim.
		 //STARTUPA GİDİP SERVICE KISMINA VAR PROFILES = DEP.EXTENSION.GETPROFILES İLE ÇEKECEĞİM
			return new List<Profile>()
			{
				new AppUserProfile(),
				new GenderProfile(),
				new AppRoleProfile()



			};
		}
	}
}
