using HospitalProject.Common;
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
	public interface IAppUserService : IService<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>
	{
		Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
		Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto dto);
		Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userid);
	}
}
