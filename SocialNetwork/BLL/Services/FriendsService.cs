using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entity;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.PLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendsService
    {
        UserRepository userRepository;
        FriendRepository friendRepository;

        public FriendsService()
        {
            userRepository = new UserRepository();
            friendRepository = new FriendRepository();
        }

        public void AddUser(FriendAddingData friendAddingData)
        {
            var friendInfo = userRepository.FindByEmail(friendAddingData.friend_email);

            if (friendInfo == null)
                throw new UserNotFoundExeption();

            var friendsEntity = new FriendsEntity()
            {
                friend_id = friendInfo.user_id,
                user_id = friendAddingData.user_id,
            };

            if (friendRepository.Create(friendsEntity) == 0)
                throw new Exception();


        }

        public void ShowAllFriends(User user)
        {
            var friendsList = friendRepository.FindAllByUserId(user.Id);

            if (friendsList == null)
                throw new UserNotFoundExeption();

            var friendsNameList = new Dictionary<string, string>();

            foreach (FriendsEntity friend in friendsList)
            {
                var oneFriend = userRepository.FindById(friend.friend_id);
                friendsNameList.Add(oneFriend.email, oneFriend.firstname);
            }

            if (friendsNameList.Count == 0)
                throw new Exception();

            SucessMessage.Show($"Вот ваши друзья, {user.FirstName}:");
            foreach (var oneFriend in friendsNameList)
            {
                Console.WriteLine($"Имя - {oneFriend.Value}, почта - {oneFriend.Key}\n");
            }

        }

    }
}
