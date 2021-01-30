using Microsoft.EntityFrameworkCore;
using YourNews.DAL.Entities;

namespace YourNews.DAL.Contexts
{
    public class YourNewsContext : DbContext
    {
        public YourNewsContext(DbContextOptions<YourNewsContext> options) : base(options)
        { }
        DbSet<Publisher> Publishers { get; set; }
        DbSet<Paper> Papers { get; set; }
        DbSet<News> News { get; set; }
        DbSet<NewsToUser> NewsToUsers { get; set; }
        DbSet<User> Users { get; set; }
    }
}
