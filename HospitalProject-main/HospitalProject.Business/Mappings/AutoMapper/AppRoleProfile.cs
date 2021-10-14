using AutoMapper;
using HospitalProject.DTOS;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Mappings.AutoMapper
{
	public class AppRoleProfile : Profile
	{
		public AppRoleProfile()
		{
			CreateMap<AppRole, AppRoleListDto>().ReverseMap();
		}
	}
}
