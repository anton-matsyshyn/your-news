

namespace YourNews.Shared.DTO
{
	public class NewsDTO: MainEntityDTO
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public int PaperId { get; set; }
	}
}
