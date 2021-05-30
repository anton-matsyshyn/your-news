using System.Collections.Generic;
using YourNews.DAL.Abstractions;

namespace YourNews.DAL.Entities
{
    public class Paper : MainEntity
    {
        public string Title { get; set; }
        public string PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<News> News { get; set; }
    }
}
