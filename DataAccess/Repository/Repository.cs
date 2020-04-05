using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		internal readonly DataAccess.Configuration.AtmoContext _context;
		internal readonly DbSet<TEntity> DbSet;

		public Repository(DataAccess.Configuration.AtmoContext context)
		{
			_context = context;
			DbSet = _context.Set<TEntity>();
		}

		public async Task<TEntity> Add(TEntity entity)
		{
			DbSet.Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task<TEntity> Delete(int id)
		{
			var entity = await DbSet.FindAsync(id);
			if (entity == null)
			{
				return entity;
			}

			DbSet.Remove(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public async Task<TEntity> Get(int id)
		{
			return await DbSet.FindAsync(id);
		}

		public IQueryable<TEntity> GetAll()
		{
			return DbSet.AsQueryable();
		}

		public async Task<TEntity> Update(TEntity entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return entity;
		}

	}
}
