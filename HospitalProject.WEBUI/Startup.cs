using AutoMapper;
using FluentValidation;
using HospitalProject.Business.DependencyResolver.Microsoft;
using HospitalProject.Business.Helpers;
using HospitalProject.Business.Interfaces;
using HospitalProject.Business.Services;
using HospitalProject.Business.ValidationRules;
using HospitalProject.DataAccess.Contexts;
using HospitalProject.DTOS;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;
using HospitalProject.WEBUI.Service;
using HospitalProject.WEBUI.Infastructure;
using HospitalProject.WEBUI.Data;
using Microsoft.EntityFrameworkCore;

namespace HospitalProject.WEBUI
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public IConfiguration Configuration { get; set; }
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			//services.AddDbContext<HospitalContext>();
			//services.AddDbContext<HospitalContext>();
			services.AddDependencies(Configuration); //sql	

			services.AddScoped<IAppUserService, AppUserService>();
			services.AddScoped<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
			services.AddScoped<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();
			services.AddScoped<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt => {   // microsoft dökümanlarından(custom cookie based authentication microsoft)

				opt.Cookie.Name = "BerkCookie";
				opt.Cookie.HttpOnly = true; //js
				opt.Cookie.SameSite = SameSiteMode.Strict; //cookie paylaşıma kapalı
				opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; //http vyea https neyle gelirse onla çalışsın cookie
				opt.ExpireTimeSpan = TimeSpan.FromDays(20);
				opt.LoginPath = new PathString("/User/Login"); //yetkisiz durum kodu, buraya gitsin
				opt.LogoutPath = new PathString("/User/LogOut");
				opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
			});
			services.AddControllersWithViews();

			var profiles = ProfileHelper.GetProfiles();//dependency ext. geldim. STATİC BİR CLASS BURDA YAZMAMAM LAZIM.
			//profiles.Add(/*new UserCreateModelProfile()*/);

			var configuration = new MapperConfiguration(opt =>
			{
				opt.AddProfiles(profiles);
			});
			var mapper = configuration.CreateMapper();
			services.AddSingleton(mapper);
			services.AddDbContext<PatentContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
			services.AddDbContext<Specimenan>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
			services.AddTransient<IPatentInformation, PatentRepo>();
			services.AddTransient<ISpecimenanddiseaseinformation, SpeccimenRepo>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication(); // microsoft dökümanlarından(custom cookie based authentication microsoft)
			app.UseAuthorization(); // microsoft dökümanlarından(custom cookie based authentication microsoft)
			app.UseCookiePolicy();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
	            name: "default",
	          pattern: "{controller=Home}/{action=Index}/{id?}");

			});
		}
	}
}
