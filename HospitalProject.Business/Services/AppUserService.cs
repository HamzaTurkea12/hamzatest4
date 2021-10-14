using AutoMapper;
using FluentValidation;
using HospitalProject.Business.Extensions;
using HospitalProject.Business.Interfaces;
using HospitalProject.Common;
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
	public class AppUserService : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>, IAppUserService
	{
		private readonly IUow _uow;
		private readonly IMapper _mapper;
		private readonly IValidator<AppUserCreateDto> _createDtoValidator;
		private readonly IValidator<AppUserLoginDto> _loginDtoValidator;
		public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> createDtoValidator, IValidator<AppUserUpdateDto> updateDtoValidator, IUow uow, IValidator<AppUserLoginDto> loginDtoValidator) : base(mapper, createDtoValidator, updateDtoValidator, uow)
		{
			_uow = uow;
			_mapper = mapper;
			_createDtoValidator = createDtoValidator;
			_loginDtoValidator = loginDtoValidator;
		}
		//bana gelecek create işlemi için gelen create sen bana bir roleıd'si ver, ben ilgili kaydı gideyim appuserole'ün içine ekleyeyim.Hem create edeyim hem de ilgili kaydı ekleyeyim

		public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId) //apusercreatedto içinde rol bilgisi yok.Benim amacım yukardaki yazılanı gerçekleştirmek. int roleıd'yi parametreye ekledim ki ben bu roleId'yi gideyim yapıştırayım
		{
			//aynı zamanda inte çevrilmiş bir enum da gönderebilirdim roleId yerine. Onu güncelleyeceğim
			var validationResult = _createDtoValidator.Validate(dto);
			if (validationResult.IsValid)
			{
				var user = _mapper.Map<AppUser>(dto);
				//1.adım
				user.AppUserRoles = new List<AppUserRole>();
				user.AppUserRoles.Add(new AppUserRole
				{
					AppUser = user,
					AppRoleId = roleId
				});

				await _uow.GetRepository<AppUser>().CreateAsync(user); //elimdeki maperla çevirme işlemi easyGASM :/4

				//  //2.adım
				//await _uow.GetRepository<AppUserRole>().CreateAsync(new AppUserRole()
				//{
				//	AppUser =  user,
				//	AppRoleIs = roleId

				//});
				await _uow.SaveChangesAsync();
				return new Response<AppUserCreateDto>(ResponseType.Success, dto);

			}

			return new Response<AppUserCreateDto>(dto, validationResult.ConvertToCustomValidationError());

		}


		public async Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto dto)
		{  //appuserlogindto yazabilirdik ama ilerleyen zamanlarda soyadı berkmen olan arkadaşı, berkmen soyadda olanlara gönder gibi, ya da daha değişik durumdaki işlmeler yapabilmek için.Bu yüzden userınmümkün olduğunca çok bilgisini geriye dönen appuserlistDto yu yazdık, appuserLoginDto yerine

			var validationResult = _loginDtoValidator.Validate(dto);
			if (validationResult.IsValid)
			{
				var user = await _uow.GetRepository<AppUser>().GetByFilterAsync(x => x.UserName == dto.UserName && x.Password == dto.Password);
				if (user != null)
				{
					var appUserDto = _mapper.Map<AppUserListDto>(user);
					return new Response<AppUserListDto>(ResponseType.Success, appUserDto);

				}
				return new Response<AppUserListDto>(ResponseType.NotFound, "Kullanıcı adı veya şifre hatalı"); //user nullsa


			}
			return new Response<AppUserListDto>(ResponseType.ValidationError, "Kullanıcı adı veya şifre boş olamaz");

		}
		//!!!!!!!!BU HATA UĞRAŞTIRMIŞTI!!! UNUTMA!!! NEDEN LİST DÖNDÜM?== BEN APPUSERSERVICEDEYİM. BİR KULLANICININ BİRDEN FAZLA ROLÜ OLABİLİR!!!! BUNDAN KAYNAKLI!!!!!!!!!!!!
		public async Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userid)   //rol bilgisi dönmem lazım, AppRole Dtom yoktu.İlk dto eklemem lazım.
		{ //amaçladığım aprolleri getirmek.


			//x=>x.AppUserId == userid ise bu kaydın rol bilgilerini getir.
			var roles = await _uow.GetRepository<AppRole>().GetAllAsync(x => x.AppUserRoles.Any(x => x.AppUserId == userid));//any varsa btw
			if (roles == null)
			{
				return new Response<List<AppRoleListDto>>(ResponseType.NotFound, "İlgili rol bulunamadı");

			}// role, rolelistdto'ya çevir.
			var dto = _mapper.Map<List<AppRoleListDto>>(roles);

			return new Response<List<AppRoleListDto>>(ResponseType.Success, dto);


		}




	}
}
