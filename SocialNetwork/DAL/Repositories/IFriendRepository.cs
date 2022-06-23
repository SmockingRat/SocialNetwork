using SocialNetwork.DAL.Entity;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Interface of friend repository
    /// </summary>
    public interface IFriendRepository
    {
        /// <summary>
        /// Method creating new entity
        /// </summary>
        /// <param name="friendEntity"> Class contains info of friends entity </param>
        /// <returns> Connection </returns>
        int Create(FriendsEntity friendEntity);

        /// <summary>
        /// Method looking for friends by user's id
        /// </summary>
        /// <param name="userId"> Id of user </param>
        /// <returns> Connection </returns>
        IEnumerable<FriendsEntity> FindAllByUserId(int userId);
        
        /// <summary>
        /// Method deletes entity
        /// </summary>
        /// <param name="id"> Entity id </param>
        /// <returns> Connection </returns>
        int Delete(int id);
    }
}
