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
    public class FriendServiceView
    {
        FriendsService friendsService;

        public FriendServiceView(FriendsService friendsService)
        {
            this.friendsService = friendsService;  
        }

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
