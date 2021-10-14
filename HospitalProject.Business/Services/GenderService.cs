using AutoMapper;
using FluentValidation;
using HospitalProject.Business.Interfaces;
using HospitalProject.DataAccess.UnitofWork;
using HospitalProject.DTOS;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Services
{
	public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>, IGenderService
	{
		public GenderService(IMapper mapper, IValidator<GenderCreateDto> genderCreateDto, IValidator<GenderUpdateDto> genderUpdateDto, IUow uow) : base(mapper, genderCreateDto, genderUpdateDto, uow)
		{


		}
	}
}
