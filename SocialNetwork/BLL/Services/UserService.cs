using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entity;
using SocialNetwork.DAL.Repositories;
using System;
using System.ComponentModel.DataAnnotations;
using SocialNetwork.BLL.Exceptions;

namespace SocialNetwork.BLL.Services
{
    /// <summary>
    /// Class works with users
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Field of MessageService class
        /// </summary>
        MessageService messageService;
        
        /// <summary>
        /// Field of IUserRepository interface
        /// </summary>
        IUserRepository userRepository;

        /// <summary>
        /// Constructor of class
        /// </summary>
        public UserService()
        {
            userRepository = new UserRepository();
            messageService = new MessageService();  
        }

        /// <summary>
        /// Method registers new users
        /// </summary>
        /// <param name="userRegistrationData"> Parameter contains important information for registrating </param>
        /// <exception cref="ArgumentNullException"> Standart exception </exception>
        /// <exception cref="Exception"> Standart exception </exception>
        public void Register(UserRegistrationData userRegistrationData)
        {
            if (String.IsNullOrEmpty(userRegistrationData.FirstName))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(userRegistrationData.LastName))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(userRegistrationData.Password))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(userRegistrationData.Email))
                throw new ArgumentNullException();

            if (userRegistrationData.Password.Length < 8)
                throw new ArgumentNullException();

            if (!new EmailAddressAttribute().IsValid(userRegistrationData.Email))
                throw new ArgumentNullException();

            if (userRepository.FindByEmail(userRegistrationData.Email) != null)
                throw new ArgumentNullException();

            var userEntity = new UserEntity()
            {
                firstname = userRegistrationData.FirstName,
                lastname = userRegistrationData.LastName,
                password = userRegistrationData.Password,
                email = userRegistrationData.Email
            };

            if (this.userRepository.Create(userEntity) == 0)
                throw new Exception();
        }

        /// <summary>
        /// Method lets user to enter his account
        /// </summary>
        /// <param name="userAuthenticationData"> Parameter contains important information for authentification </param>
        /// <returns> New user model </returns>
        /// <exception cref="UserNotFoundExeption"> Special exception </exception>
        /// <exception cref="WrongPasswordExeption"> Special exception </exception>
        public User Authenticate(UserAuthentificationData userAuthenticationData)
        {
            var findUserEntity = userRepository.FindByEmail(userAuthenticationData.Email);
            if (findUserEntity is null) throw new UserNotFoundExeption();

            if (findUserEntity.password != userAuthenticationData.Password)
                throw new WrongPasswordExeption();

            return ConstructUserModel(findUserEntity);
        }

        /// <summary>
        /// Method updates user's data
        /// </summary>
        /// <param name="user"> Data of user </param>
        /// <exception cref="Exception"> Standart exception </exception>
        public void Update(User user)
        {
            var updatableUserEntity = new UserEntity()
            {
                user_id = user.Id,
                firstname = user.FirstName,
                lastname = user.LastName,
                password = user.Password,
                email = user.Email,
                photo = user.Photo,
                favorite_movie = user.FavoriteMovie,
                favorite_book = user.FavoriteBook
            };

            if (this.userRepository.Update(updatableUserEntity) == 0)
                throw new Exception();
        }

        /// <summary>
        /// Method make up new user model
        /// </summary>
        /// <param name="userEntity"> Entity of user in database </param>
        /// <returns> User entity </returns>
        private User ConstructUserModel(UserEntity userEntity)
        {
            var incomingMessages = messageService.GetIncomingMessagesByUserId(userEntity.user_id);

            var outgoingMessages = messageService.GetOutcomingMessagesByUserId(userEntity.user_id);

            return new User(userEntity.user_id,
                          userEntity.firstname,
                          userEntity.lastname,
                          userEntity.password,
                          userEntity.email,
                          userEntity.photo,
                          userEntity.favorite_movie,
                          userEntity.favorite_book,
                          incomingMessages,
                          outgoingMessages);
        }

        /// <summary>
        /// Method looking for user by his id
        /// </summary>
        /// <param name="id"> Parameter contains user's id </param>
        /// <returns> User model </returns>
        /// <exception cref="UserNotFoundExeption"> Special exception </exception>
        public User FindById(int id)
        {
            var findUserEntity = userRepository.FindById(id);
            if (findUserEntity is null) throw new UserNotFoundExeption();

            return ConstructUserModel(findUserEntity);
        }
    }
}
