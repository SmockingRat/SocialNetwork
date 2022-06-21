using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Veiws
{
    public class MainView
    {

        public static UserService userService = new UserService();

        public void Show()
        {
            Console.WriteLine("Добро пожаловать в социальную сеть.");

            while (true)
            {
                Console.WriteLine("\nВойти в профиль (нажмите 1)");
                Console.WriteLine("Зарегистрироваться (нажмите 2)");
                Console.WriteLine("Выйти (Нажмите 3)");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Program.authentificationView.Show();
                            break;
                        }

                    case "2":
                        {
                            Program.registrationView.Show();
                            break;
                        }
                    case "3":
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }


    }
}
