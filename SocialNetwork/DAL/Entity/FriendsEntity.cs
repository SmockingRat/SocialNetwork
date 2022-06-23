namespace SocialNetwork.DAL.Entity
{
    /// <summary>
    /// Class describes frind entity
    /// </summary>
    public class FriendsEntity
    {
        /// <summary>
        /// Id of entity
        /// </summary>
        public int id_friends { get; set; }
        
        /// <summary>
        /// Id of user
        /// </summary>
        public int user_id { get; set; }
        
        /// <summary>
        /// Id of user's friend
        /// </summary>
        public int friend_id { get; set; }
    }

}
