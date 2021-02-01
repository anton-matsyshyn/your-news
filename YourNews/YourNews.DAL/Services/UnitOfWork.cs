using YourNews.DAL.Contexts;

namespace WebApplication1.Models
{

	public class UnitOfWork : IUnitOfWorks
	{
		public YourNewsContext db = new YourNewsContext();
		public void Save()
		{
			db.SaveChanges();
		}
	}
}
