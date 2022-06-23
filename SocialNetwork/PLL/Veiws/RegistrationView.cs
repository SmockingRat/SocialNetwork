using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class shows registration view
    /// </summary>
    internal class RegistrationView
    {
        /// <summary>
        /// Field of UserService class
        /// </summary>
        UserService userService;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="user"> UserService parameter </param>
        public RegistrationView(UserService user)
        {
            userService = user;
        }

        /// <summary>
        /// Method shows view
        /// </summary>
        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.WriteLine("\nДля создания нового профиля введите ваше имя:");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.Write("Ваша фамилия:");
            userRegistrationData.LastName = Console.ReadLine();

            Console.Write("Пароль:");
            userRegistrationData.Password = Console.ReadLine();

            Console.Write("Почтовый адрес:");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                userService.Register(userRegistrationData);
                SucessMessage.Show("Ваш профиль успешно создан. Теперь Вы можете войти в систему под своими учетными данными.");
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Введите корректное значение.");
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла ошибка при регистрации.");
            }

        }

    }
}
