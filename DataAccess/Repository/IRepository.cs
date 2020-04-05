using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public interface IRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> GetAll();
		Task<TEntity> Get(int id);
		Task<TEntity> Add(TEntity entity);
		Task<TEntity> Update(TEntity entity);
		Task<TEntity> Delete(int id);
	}
}
