using SocialNetwork.DAL.Entity;
using System.Collections.Generic;


namespace SocialNetwork.DAL.Repositories
{
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        public IEnumerable<FriendsEntity> FindAllByUserId(int userId)
        {
            return Query<FriendsEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }

        public int Create(FriendsEntity friendEntity)
        {
            Execute(@"insert into friends (user_id,friend_id) values (:friend_id,:user_id)", friendEntity);
            return Execute(@"insert into friends (user_id,friend_id) values (:user_id,:friend_id)", friendEntity);
        }

        public int Delete(int id)
        {
            return Execute(@"delete from friends where friends_id = :id_p", new { id_p = id });
        }
    }
}
