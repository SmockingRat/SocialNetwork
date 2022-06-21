using SocialNetwork.DAL.Entity;
using System.Collections.Generic;


namespace SocialNetwork.DAL.Repositories
{
    public interface IFriendRepository
    {
        int Create(FriendsEntity friendEntity);
        IEnumerable<FriendsEntity> FindAllByUserId(int userId);
        int Delete(int id);
    }
}
