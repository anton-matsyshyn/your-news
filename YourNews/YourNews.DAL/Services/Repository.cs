using System.Collections.Generic;
using System.Linq;
using YourNews.DAL.Abstractions;
using YourNews.DAL.Contexts;
using YourNews.DAL.Interfaces;

namespace WebApplication1.Models
{
	public class Repository<T> where T : MainEntity, IRepository<T>
	{
		private YourNewsContext db;
		public Repository(YourNewsContext context)
		{
			this.db = context;
		}
		public IQueryable<T> GetAll()
		{
			return db.Set<T>();
		}
		public T Get(int id)
		{
			return db.Set<T>().Single(e => e.Id == id);
		}
		public void Create(T entity)
		{
			db.Set<T>().Add(entity);
		}
		public void Update(T entity)
		{
			db.Set<T>().Update(entity);
		}
		public void Delete(int id)
		{
			T entity = db.Set<T>().SingleOrDefault(e => e.Id == id);
			if (entity != null)
			{
				db.Set<T>().Remove(entity);
			}
		}
	}
}
