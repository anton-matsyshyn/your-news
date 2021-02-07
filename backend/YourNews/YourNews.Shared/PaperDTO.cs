using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNews.Shared
{
	class PaperDTO: MainEntityDTO
	{
		public string Title { get; set; }
		public string PublisherId { get; set; }
	}
}
