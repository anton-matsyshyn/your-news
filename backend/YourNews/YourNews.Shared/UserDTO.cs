using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNews.Shared
{
	class UserDTO: MainEntityDTO
	{
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Mail { get; set; }
        public string NickName { get; set; }
        public DateTime BithDate { get; set; }
        public int? PublisherId { get; set; }
    }
}
