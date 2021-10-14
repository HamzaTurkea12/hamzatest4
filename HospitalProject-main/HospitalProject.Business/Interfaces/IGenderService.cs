using HospitalProject.DTOS;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HospitalProject.Business.Interfaces.IService;

namespace HospitalProject.Business.Interfaces
{
	public interface IGenderService : IService<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>
	{

	}
}
