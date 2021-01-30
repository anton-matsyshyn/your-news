using YourNews.DAL.Abstractions;

namespace YourNews.DAL.Entities
{
    class NewsToUser : MainEntity
    {
        public int NewsId { get; set; }
        public News News { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
