using System.Collections.Generic;
using YourNews.DAL.Abstractions;

namespace YourNews.DAL.Entities
{
    class Publisher : MainEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public List<Paper> Papers { get; set; }
        public List<User> Users { get; set; }
    }
}
