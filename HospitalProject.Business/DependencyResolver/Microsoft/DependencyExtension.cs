using FluentValidation;
using HospitalProject.Business.Interfaces;
using HospitalProject.Business.Services;
using HospitalProject.Business.ValidationRules;
using HospitalProject.DataAccess.Contexts;
using HospitalProject.DataAccess.UnitofWork;
using HospitalProject.DTOS;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.DependencyResolver.Microsoft
{
	public static class DependencyExtension
	{
		public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
		{

			services.AddDbContext<HospitalContext>(opt =>
			{
				opt.UseSqlServer(configuration.GetConnectionString("Local"));
			});



			services.AddScoped<IUow, Uow>();


			services.AddScoped<IAppUserService, AppUserService>();


			services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
			services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
			services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();
			services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();




		}
	}
}
