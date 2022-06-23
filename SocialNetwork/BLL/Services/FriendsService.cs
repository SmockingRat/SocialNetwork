using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entity;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.PLL;
using System;
using System.Collections.Generic;

namespace SocialNetwork.BLL.Services
{
    /// <summary>
    /// Class works with friends
    /// </summary>
    public class FriendsService
    {
        /// <summary>
        /// Field of UserRepository class
        /// </summary>
        UserRepository userRepository;
        /// <summary>
        /// Field of FriendRepository class
        /// </summary>
        FriendRepository friendRepository;

        /// <summary>
        /// Constructor of class
        /// </summary>
        public FriendsService()
        {
            userRepository = new UserRepository();
            friendRepository = new FriendRepository();
        }

        /// <summary>
        /// Method add two users in "friend" entity
        /// </summary>
        /// <param name="friendAddingData"> Parameter contain imrotant data for adding in entity </param>
        /// <exception cref="UserNotFoundExeption"> Type of special exception </exception>
        /// <exception cref="Exception"> Standart exception </exception>
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

        /// <summary>
        /// Method show all friends
        /// </summary>
        /// <param name="user"> Parameter contaains user's data </param>
        /// <exception cref="UserNotFoundExeption"> Special exception </exception>
        /// <exception cref="Exception"> Standart exception </exception>
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
