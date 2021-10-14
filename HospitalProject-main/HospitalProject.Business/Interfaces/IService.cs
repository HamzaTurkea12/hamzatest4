using HospitalProject.Common;
using HospitalProject.DTOS.Interfaces;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Interfaces
{
	public interface IService
	{
		public interface IService<CreateDto, UpdateDto, ListDto, T> //neden provideservice yazmadı bunları yazdım, çünkü bu generic. Sadece provide service hizmet etmiyor. Diğer entityler için de geçerli
		where CreateDto : class, IDto, new()
		where UpdateDto : class, IUpdateDto, new()
		where ListDto : class, IDto, new()
		where T : BaseEntity
		{//createDto bir class olmalı, IDto'dan implemente olmalı ve newlenmeli

			Task<IResponse<CreateDto>> CreateAsync(CreateDto dto); //baştaki parametre olarak aldım onu dönecğim.
			Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);
			Task<IResponse<IDto>> GetByIdAsync<IDto>(int id); //ön tarafta neye ihtiyaç varsa onu getirsin diye IDto
			Task<IResponse> RemoveAsync(int id);
			Task<IResponse<List<ListDto>>> GetAllAsync(); //doğrudan ilgili datayı çekiyor
		}
	}
}
