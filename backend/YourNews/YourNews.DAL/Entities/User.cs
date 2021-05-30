using System;
using System.Collections.Generic;
using YourNews.DAL.Abstractions;

namespace YourNews.DAL.Entities
{
    public class User : MainEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Mail { get; set; }
        public string NickName { get; set; }
        public DateTime BithDate { get; set; }
        public List<NewsToUser> NewsToUsers { get; set; }
        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
