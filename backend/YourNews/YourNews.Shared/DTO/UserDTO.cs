using System;

namespace YourNews.Shared.DTO
{
	public class UserDTO: MainEntityDTO
	{
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Mail { get; set; }
        public string NickName { get; set; }
        public DateTime BithDate { get; set; }
        public int? PublisherId { get; set; }
    }
}
