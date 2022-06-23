using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Veiws;

namespace SocialNetwork
{
    /// <summary>
    /// Entry class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Fields for work
        /// </summary>
        static UserService userService;
        static MessageService messageService;
        static FriendsService friendsService;
        public static MainView mainView;
        public static AuthentificationView authentificationView;
        public static RegistrationView registrationView;
        public static UserMenuView userMenu;
        public static ShowUserInfoView showUser;
        public static UpdateUserInfoView updateUserInfo;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static FriendServiceView friendServiceView;
        public static FriendsAddingView friendsAddingView;

        /// <summary>
        /// Entry method
        /// </summary>
        /// <param name="args"> Entry parameter </param>
        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendsService = new FriendsService();  
            mainView = new MainView();
            authentificationView = new AuthentificationView(userService);
            registrationView = new RegistrationView(userService);
            userMenu = new UserMenuView(userService);
            showUser = new ShowUserInfoView();
            updateUserInfo = new UpdateUserInfoView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            friendServiceView = new FriendServiceView(friendsService);
            friendsAddingView = new FriendsAddingView(friendsService);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
