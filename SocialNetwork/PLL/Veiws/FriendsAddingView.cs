using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Veiws
{
    public class FriendsAddingView
    {
        FriendsService friendsService;

        public FriendsAddingView(FriendsService friendsService)
        {
            this.friendsService=friendsService;
        }

        public void Show(User user)
        {
            Console.WriteLine("Введите почту добавляемого друга:");
            string email = Console.ReadLine();

            var friendEntityInfo = new FriendAddingData()
            {
                friend_email = email,
                user_id = user.Id,
            };

            try
            {
                friendsService.AddUser(friendEntityInfo);

                SucessMessage.Show("Друг успешно добавлен");
            }
            catch(UserNotFoundExeption)
            {
                AlertMessage.Show("Такого пользователя не существует");
            }
            catch(Exception)
            {
                AlertMessage.Show("Произошла ошибка при записи");
            }


        }
    }
}
