using System;
using Welcome.Others;

namespace Welcome.Model
{
	public class User
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public UserRolesEnum Role { get; set; }

		public User(string name, string password, UserRolesEnum userRole)
		{
			Name = name;
			Password = password;
			Role = userRole;
		}

        public User()
        {
        }
    }
}

