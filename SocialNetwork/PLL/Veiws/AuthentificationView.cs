using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Veiws
{
    public class AuthentificationView
    {
        UserService user;

        public AuthentificationView(UserService userService)
        {
            user = userService;
        }


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
