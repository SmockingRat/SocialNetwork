using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using SocialNetwork.BLL.Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.PLL.Veiws;

namespace SocialNetwork
{
    internal class Program
    {
        static UserService userService;
        static MessageService messageService;
        public static MainView mainView;
        public static AuthentificationView authentificationView;
        public static RegistrationView registrationView;
        public static UserMenuView userMenu;
        public static ShowUserInfoView showUser;
        public static UpdateUserInfoView updateUserInfo;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            mainView = new MainView();
            authentificationView = new AuthentificationView(userService);
            registrationView = new RegistrationView(userService);
            userMenu = new UserMenuView(userService);
            showUser = new ShowUserInfoView();
            updateUserInfo = new UpdateUserInfoView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
