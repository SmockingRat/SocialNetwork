using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Linq;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class show user's menu
    /// </summary>
    public class UserMenuView
    {
        /// <summary>
        /// Field of UserService class
        /// </summary>
        UserService userService;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="user"> Parameter of UserService class </param>
        public UserMenuView(UserService user)
        {
            this.userService = user;
        }

        /// <summary>
        /// Method shows view
        /// </summary>
        /// <param name="user"> User's data </param>
        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("\nВходящие сообщения: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Исходящие сообщения: {0}", user.OutgoingMessages.Count());
                Console.WriteLine("Просмотреть информацию о моём профиле (нажмите 1)");
                Console.WriteLine("Редактировать мой профиль (нажмите 2)");
                Console.WriteLine("Перейти в меню друзей (нажмите 3)");
                Console.WriteLine("Написать сообщение (нажмите 4)");
                Console.WriteLine("Просмотреть входящие сообщения (нажмите 5)");
                Console.WriteLine("Просмотреть исходящие сообщения (нажмите 6)");
                Console.WriteLine("Выйти из профиля (нажмите 7)\n");

                char UserKey = Console.ReadKey().KeyChar;

                if (UserKey == '7') break;

                switch (UserKey)
                {
                    case '1':
                        {
                            Program.showUser.Show(user);
                            break;
                        }
                    case '2':
                        {
                            Program.updateUserInfo.Show(user);
                            break;
                        }
                    case '3':
                        {
                            Program.friendServiceView.Show(user);
                            break;
                        }
                    case '4':
                        {
                            Program.messageSendingView.Show(user);
                            break;
                        }
                    case '5':
                        {
                            Program.userIncomingMessageView.Show(user.IncomingMessages);   
                            break;
                        }
                    case '6':
                        {
                            Program.userOutcomingMessageView.Show(user.OutgoingMessages);
                            break;
                        }
                }
            }
        }
    }
}
