using SocialNetwork.DAL.Entity;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Class describes friend repository
    /// </summary>
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        /// <summary>
        /// Method return all friends by id
        /// </summary>
        /// <param name="userId"> ID of user </param>
        /// <returns> List of friends </returns>
        public IEnumerable<FriendsEntity> FindAllByUserId(int userId)
        {
            return Query<FriendsEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }

        /// <summary>
        /// Method creates new entity
        /// </summary>
        /// <param name="friendEntity"> Parameter contains friend entity </param>
        /// <returns> Connection </returns>
        public int Create(FriendsEntity friendEntity)
        {
            Execute(@"insert into friends (user_id,friend_id) values (:friend_id,:user_id)", friendEntity);
            return Execute(@"insert into friends (user_id,friend_id) values (:user_id,:friend_id)", friendEntity);
        }

        /// <summary>
        /// Method deletes entity by Id
        /// </summary>
        /// <param name="id"> User id </param>
        /// <returns> Connection </returns>
        public int Delete(int id)
        {
            return Execute(@"delete from friends where friends_id = :id_p", new { id_p = id });
        }
    }
}
