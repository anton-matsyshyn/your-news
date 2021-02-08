using System;

namespace YourNews.Shared.DTO
{
	public abstract class MainEntityDTO
	{
		public int Id { get; set; }
		public DateTime CreatingDate { get; set; }
	}
}
