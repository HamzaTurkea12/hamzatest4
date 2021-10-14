using HospitalProject.DataAccess.Interfaces;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.UnitofWork
{
	public interface IUow
	{
		IRepository<T> GetRepository<T>() where T : BaseEntity;
		Task SaveChangesAsync();
	}
}
