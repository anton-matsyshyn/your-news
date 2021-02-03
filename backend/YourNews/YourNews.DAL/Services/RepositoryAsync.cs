using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YourNews.DAL.Abstractions;
using YourNews.DAL.Contexts;
using YourNews.DAL.Interfaces;

namespace WebApplication1.Models
{
	public class RepositoryAsync<T> where T : MainEntity, IRepositoryAsync<T>
	{
		private YourNewsContext db;

		public RepositoryAsync(YourNewsContext context)
		{
			this.db = context;
		}
		public async Task<T> Get(int id)
		{
			return await db.Set<T>().SingleAsync(e => e.Id == id);
		}
		public async Task CreateAsync(T entity)
		{
			await db.Set<T>().AddAsync(entity);
		}
	}
}
