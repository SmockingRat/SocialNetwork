using SocialNetwork.DAL.Entity;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Interface of user repository
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Method creates new user entity
        /// </summary>
        /// <param name="userEntity"> Class contains user entity </param>
        /// <returns> Connection </returns>
        int Create(UserEntity userEntity);
        
        /// <summary>
        /// Method looking for user entity by email
        /// </summary>
        /// <param name="email"> Email </param>
        /// <returns> Object </returns>
        UserEntity FindByEmail(string email);
        
        /// <summary>
        /// Method returns all user entities
        /// </summary>
        /// <returns> List of users </returns>
        IEnumerable<UserEntity> FindAll();
        
        /// <summary>
        /// Method looking for user by id
        /// </summary>
        /// <param name="user_id"> Id of user </param>
        /// <returns> User entity </returns>
        UserEntity FindById(int user_id);
        
        /// <summary>
        /// Method updates data
        /// </summary>
        /// <param name="userEntity"> Class describes user entity </param>
        /// <returns> Connection </returns>
        int Update(UserEntity userEntity);
        
        /// <summary>
        /// Method deletes user by id
        /// </summary>
        /// <param name="user_id"> Id of user </param>
        /// <returns> Connection </returns>
        int DeleteById(int user_id);
    }
}
