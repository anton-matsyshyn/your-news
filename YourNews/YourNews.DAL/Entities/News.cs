using System.Collections.Generic;
using YourNews.DAL.Abstractions;

namespace YourNews.DAL.Entities
{
    class News : MainEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int PaperId { get; set; }
        public Paper Paper { get; set; }
        public List<NewsToUser> NewsToUsers { get; set; }
    }
}
