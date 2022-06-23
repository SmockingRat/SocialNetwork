using SocialNetwork.BLL.Services;
using System;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class show main view
    /// </summary>
    public class MainView
    {
        /// <summary>
        /// Field of UserService class
        /// </summary>
        public static UserService userService = new UserService();

        /// <summary>
        /// Method show view
        /// </summary>
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
