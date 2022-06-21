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
    public class UpdateUserInfoView
    {
        UserService userService;

        public UpdateUserInfoView(UserService userService)
        {
            this.userService=userService;
        }

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
