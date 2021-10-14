using HospitalProject.Common.Enums;
using HospitalProject.DataAccess.Contexts;
using HospitalProject.DataAccess.Interfaces;
using HospitalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Repositories
{
	public class Repository<T>: IRepository<T> where T : BaseEntity
	{
		private readonly HospitalContext _context;
		public Repository(HospitalContext context)
		{
			_context = context;
		}


		public async Task<List<T>> GetAllAsync()
		{
			return await _context.Set<T>().AsNoTracking().ToListAsync();
		}

		public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter) //FUNC DELEGETİM t'Yİ alacak geriye boolean dönecek filtreleyerek
		{
			return await _context.Set<T>().AsNoTracking().Where(filter).AsNoTracking().ToListAsync();
		}

		public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC) //sıralayarak
		{
			return orderByType == OrderByType.ASC ? await _context.Set<T>().AsNoTracking().OrderBy(selector).ToListAsync() : await _context.Set<T>().AsNoTracking().OrderByDescending(selector).ToListAsync();
		}

		public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC) //hem listeleme hem filtr
		{
			return orderByType == OrderByType.ASC ? await _context.Set<T>().Where(filter).AsNoTracking().OrderBy(selector).ToListAsync() : await _context.Set<T>().Where(filter).AsNoTracking().OrderByDescending(selector).ToListAsync();
		}

		public async Task<T> FindAsync(object id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false)  //id ile değilde başka bir şeyle arayacağım veya Id ile getireceğim ancak AsNoTracking olsun istemiyorum.
		{ //ilki asn. yoksa, diğeri varsa (true)
			return !asNoTracking ? await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter) : await _context.Set<T>().SingleOrDefaultAsync(filter);
		}

		public IQueryable<T> GetQuery()
		{
			return _context.Set<T>().AsQueryable();

		}
		public void Remove(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public async Task CreateAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
		}

		public void Update(T entity, T unchanged)
		{
			_context.Entry(unchanged).CurrentValues.SetValues(entity); //değişmemişi veriyorum yani çektiğimi(unc)
		}





























	}
}
