using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using System;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class show view of friends adding
    /// </summary>
    public class FriendsAddingView
    {
        /// <summary>
        /// Field of FriendsDervice class
        /// </summary>
        FriendsService friendsService;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="friendsService"> Parameter of FriendsService class </param>
        public FriendsAddingView(FriendsService friendsService)
        {
            this.friendsService=friendsService;
        }

        /// <summary>
        /// Method show view
        /// </summary>
        /// <param name="user"> Data of user </param>
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
