using System;
using Welcome.ViewModel;

namespace Welcome.View
{
	public class UserView
	{
		private UserViewModel _userViewModel;
		public UserView(UserViewModel userViewModel)
		{
			_userViewModel = userViewModel;
		}

		public void Display()
		{
			Console.WriteLine("Welcome  User: " + _userViewModel.Name + " Role: " + _userViewModel.UserRole);
		}
	}
}

