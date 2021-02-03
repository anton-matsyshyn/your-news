using YourNews.DAL.Contexts;

namespace WebApplication1.Models
{

	public class UnitOfWork : IUnitOfWorks
	{
		public YourNewsContext db;

		public UnitOfWork(YourNewsContext context)
		{
			this.db = context;
		}
		public void Save()
		{
			db.SaveChanges();
		}
	}
}
