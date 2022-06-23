using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class of view of authentification
    /// </summary>
    public class AuthentificationView
    {
        /// <summary>
        /// Field of UserService class
        /// </summary>
        UserService user;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="userService"> Parameter of Userservice class </param>
        public AuthentificationView(UserService userService)
        {
            user = userService;
        }

        /// <summary>
        /// Methos show view
        /// </summary>
        public void Show()
        {
            var authenticationData = new UserAuthentificationData();

            Console.WriteLine("\nВведите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                User user = this.user.Authenticate(authenticationData);

                SucessMessage.Show("Вы успешно вошли в социальную сеть! Добро пожаловать" + user.FirstName);

                Program.userMenu.Show(user);
            }
            catch (WrongPasswordExeption)
            {
                AlertMessage.Show("Неправильный пароль!");
            }
            catch (UserNotFoundExeption)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
        }
    }
}
