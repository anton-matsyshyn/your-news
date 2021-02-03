using System.Threading.Tasks;
using YourNews.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{

	public class UnitOfWorksAsync : IUnitOfWorksAsync
	{
		private YourNewsContext db;

		public UnitOfWorksAsync(YourNewsContext context)
		{
			this.db = context;
		}
		public async Task SaveAsync()
		{
			await db.SaveChangesAsync();
		}
	}
}
