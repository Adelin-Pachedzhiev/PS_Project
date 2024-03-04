using System;
using Welcome.Others;

namespace Welcome.Model
{
	public class User
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public UserRolesEnum Role { get; set; }

		public User(string names, string password, UserRolesEnum userRole)
		{
			Name = names;
			Password = password;
			Role =userRole;
		}
	}
}

