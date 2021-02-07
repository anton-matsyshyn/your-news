using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNews.Shared
{
	class NewsDTO: MainEntityDTO
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public int PaperId { get; set; }
	}
}
