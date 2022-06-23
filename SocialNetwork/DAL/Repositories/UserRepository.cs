using SocialNetwork.DAL.Entity;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Class of user repository
    /// </summary>
    public class UserRepository: BaseRepository, IUserRepository
    {
        /// <summary>
        /// Method creates new user entity
        /// </summary>
        /// <param name="userEntity"> Class contains user entity </param>
        /// <returns> Connection </returns>
        public int Create(UserEntity userEntity)
        {
            return Execute(@"insert into users (firstname,lastname,password,email) 
                             values (:firstname,:lastname,:password,:email)", userEntity);
        }

        /// <summary>
        /// Method returns all user entities
        /// </summary>
        /// <returns> List of users </returns>
        public IEnumerable<UserEntity> FindAll()
        {
            return Query<UserEntity>("select * from users");
        }

        /// <summary>
        /// Method looking for user entity by email
        /// </summary>
        /// <param name="email"> Email </param>
        /// <returns> Object </returns>
        public UserEntity FindByEmail(string email)
        {
            return QueryFirstOrDefault<UserEntity>("select * from users where email = :email_p", new { email_p = email });
        }

        /// <summary>
        /// Method looking for user by id
        /// </summary>
        /// <param name="id"> Id of user </param>
        /// <returns> User entity </returns>
        public UserEntity FindById(int id)
        {
            return QueryFirstOrDefault<UserEntity>("select * from users where user_id = :id_p", new { id_p = id });
        }

        /// <summary>
        /// Method updates data
        /// </summary>
        /// <param name="userEntity"> Class describes user entity </param>
        /// <returns> Connection </returns>
        public int Update(UserEntity userEntity)
        {
            return Execute(@"update users set firstname = :firstname, lastname = :lastname, password = :password, email = :email,
                             photo = :photo, favorite_movie = :favorite_movie, favorite_book = :favorite_book where user_id = :user_id", userEntity);
        }

        /// <summary>
        /// Method deletes user by id
        /// </summary>
        /// <param name="user_id"> Id of user </param>
        /// <returns> Connection </returns>
        public int DeleteById(int id)
        {
            return Execute("delete from users where user_id = :id_p", new { id_p = id });
        }
    }
}

