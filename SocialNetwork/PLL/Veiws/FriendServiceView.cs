using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class of friend service view
    /// </summary>
    public class FriendServiceView
    {
        /// <summary>
        /// Field of FriendsService class
        /// </summary>
        FriendsService friendsService;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="friendsService"> Parameter of FriendsService class </param>
        public FriendServiceView(FriendsService friendsService)
        {
            this.friendsService = friendsService;  
        }

        /// <summary>
        /// Method show view
        /// </summary>
        /// <param name="user"> Data of user </param>
        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Добавить друга - 1,\nПоказать друзей - 2,\nВернуться в меню - 3\n");
                char userKey = Console.ReadKey().KeyChar;

                if (userKey == '3')
                    break;

                switch (userKey)
                {
                    case '1':
                        {
                            Program.friendsAddingView.Show(user);
                            break;
                        }
                    case '2':
                        {
                            try
                            {
                                this.friendsService.ShowAllFriends(user);
                                break;
                            }
                            catch(UserNotFoundExeption)
                            {
                                AlertMessage.Show("Такого пользователя нет");
                                break;
                            }
                            catch(Exception)
                            {
                                SucessMessage.Show("\nУ вас нет друзей. Пока что!\n");
                                break;
                            }
                        }
                }
            }
        }
    }
}
