using System.Linq;
using System.Threading.Tasks;

namespace YourNews.DAL.Interfaces
{
	public interface IRepositoryAsync<T> where T : class
	{
		IQueryable<T> GetAll();
		Task<T> Get(int id);
		Task CreateAsync(T item);
		Task Update(T item);
		Task Delete(int id);
	}
}
