using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class shows view for user data update
    /// </summary>
    public class UpdateUserInfoView
    {
        /// <summary>
        /// Field of UserService class
        /// </summary>
        UserService userService;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="userService"> Parameter of UserService class </param>
        public UpdateUserInfoView(UserService userService)
        {
            this.userService=userService;
        }

        /// <summary>
        /// Method shows view
        /// </summary>
        /// <param name="user"> User data </param>
        public void Show(User user)
        {
            Console.Write("Меня зовут:");
            user.FirstName = Console.ReadLine();

            Console.Write("Моя фамилия:");
            user.LastName = Console.ReadLine();

            Console.Write("Ссылка на моё фото:");
            user.Photo = Console.ReadLine();

            Console.Write("Мой любимый фильм:");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("Моя любимая книга:");
            user.FavoriteBook = Console.ReadLine();
            try
            {
                userService.Update(user);
                SucessMessage.Show("Ваш профиль успешно обновлён!");
            }
            catch(Exception)
            {
                AlertMessage.Show("Что-то пошло не так!");
            }
        }
    }
}
