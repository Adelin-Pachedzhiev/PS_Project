﻿using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome;

class Program
{
    static void Main(string[] args)
    {

        User user = new User("Kaloyan", "pass123", UserRolesEnum.STUDENT);

        UserViewModel userViewModel = new UserViewModel(user);

        UserView userView = new UserView(userViewModel);

        userView.Display();

        Console.ReadKey();

    }
}

