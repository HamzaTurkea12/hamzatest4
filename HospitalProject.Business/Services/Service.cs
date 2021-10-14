using AutoMapper;
using FluentValidation;
using HospitalProject.Business.Extensions;
using HospitalProject.Common;
using HospitalProject.DataAccess.UnitofWork;
using HospitalProject.DTOS.Interfaces;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HospitalProject.Business.Interfaces.IService;

namespace HospitalProject.Business.Services
{
	public class Service<CreateDto, UpdateDto, ListDto, T> : IService<CreateDto, UpdateDto, ListDto, T> //IService bir T tipi alsın
		where CreateDto : class, IDto, new()
		where UpdateDto : class, IUpdateDto, new()
		where ListDto : class, IDto, new()
		where T : BaseEntity
	{
		private readonly IMapper _mapper;
		private readonly IValidator<CreateDto> _createDtoValidator; //artık burda createDto olarak ne çalışırsa onun validatoru çalışacak.
		private readonly IValidator<UpdateDto> _updateDtoValidator;
		private readonly IUow _uow;

		public Service(IMapper mapper, IValidator<CreateDto> createDtoValidator, IValidator<UpdateDto> updateDtoValidator, IUow uow)
		{
			_mapper = mapper;
			_createDtoValidator = createDtoValidator;
			_updateDtoValidator = updateDtoValidator;
			_uow = uow;
		}

		public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
		{
			//valid? ilk valid mi değil mi ?, bunun için de validation controlü kullanıyorduk._createDtoValidator olacak ve bunun aracılığıla validate edeceğiz
			//_uow.GetRepository<T>().CreateAsync(_mapper.Map<T>(dto)) 
			//response<T>(dto)
			var result = _createDtoValidator.Validate(dto);
			if (result.IsValid)
			{
				var createdEntity = _mapper.Map<T>(dto);
				await _uow.GetRepository<T>().CreateAsync(createdEntity);
				await _uow.SaveChangesAsync();
				return new Response<CreateDto>(ResponseType.Success, dto);
			}

			return new Response<CreateDto>(dto, result.ConvertToCustomValidationError()); //response common, data ve hata mesajı List<CustomValidationError> yazmayıp new yazdık. Extensin class üzerinden bütün işlemlri hallediyoruz.Aslında ilgili Uı'ın içinde responsea dönmemiz lazım
		}

		public async Task<IResponse<List<ListDto>>> GetAllAsync()
		{
			var data = await _uow.GetRepository<T>().GetAllAsync();
			var dto = _mapper.Map<List<ListDto>>(data);
			return new Response<List<ListDto>>(ResponseType.Success, dto);

		}

		public async Task<IResponse<IDto>> GetByIdAsync<IDto>(int id)
		{
			var data = await _uow.GetRepository<T>().GetByFilterAsync(x => x.Id == id);
			if (data == null)
				return new Response<IDto>(ResponseType.NotFound, $"{id} ye sahip data bulunamadı");

			var dto = _mapper.Map<IDto>(data);  //değilse
			return new Response<IDto>(ResponseType.Success, dto);

		}

		public async Task<IResponse> RemoveAsync(int id)
		{
			var data = await _uow.GetRepository<T>().FindAsync(id);
			if (data == null)
				return new Response(ResponseType.NotFound, $"{id} ye sahip data bulunamadı");
			_uow.GetRepository<T>().Remove(data);
			await _uow.SaveChangesAsync();
			return new Response(ResponseType.Success);

		}

		public async Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto) //updateDto aslında bir IDto
		{
			var result = _updateDtoValidator.Validate(dto);
			if (result.IsValid)
			{

				var unchangedData = await _uow.GetRepository<T>().FindAsync(dto.Id); //burdan bir Id göndermeye çalışsam IDto'da bir Id sekmesi yok. O yüzden yeni bir IUpdateDto diye düzeltmeliyim yukardan classı ve oluşturmalıyım
				if (unchangedData == null)
					return new Response<UpdateDto>(ResponseType.NotFound, $"{dto.Id} ye ait data bulunamadı");
				var entity = _mapper.Map<T>(dto);
				_uow.GetRepository<T>().Update(entity, unchangedData);
				await _uow.SaveChangesAsync();
				return new Response<UpdateDto>(ResponseType.Success, dto);
			}

			return new Response<UpdateDto>(dto, result.ConvertToCustomValidationError());




		}
	}
}
