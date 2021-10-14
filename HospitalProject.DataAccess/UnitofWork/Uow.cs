using HospitalProject.DataAccess.Contexts;
using HospitalProject.DataAccess.Interfaces;
using HospitalProject.DataAccess.Repositories;
using HospitalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.UnitofWork
{
	public class Uow: IUow
	{
		private readonly HospitalContext _context;
		public Uow(HospitalContext context)
		{
			_context = context;
		}

		public IRepository<T> GetRepository<T>() where T : BaseEntity
		{
			return new Repository<T>(_context);
		}
		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}


	}
}
