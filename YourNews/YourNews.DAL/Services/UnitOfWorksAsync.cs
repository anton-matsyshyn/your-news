using System.Threading.Tasks;
using YourNews.DAL.Contexts;

namespace WebApplication1.Models
{

	public class UnitOfWorksAsync : IUnitOfWorksAsync
	{
		private YourNewsContext db = new YourNewsContext();
		public async Task SaveAsync()
		{
			await db.SaveChangesAsync();
		}
	}
}
