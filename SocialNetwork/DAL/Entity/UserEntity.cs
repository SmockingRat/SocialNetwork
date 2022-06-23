namespace SocialNetwork.DAL.Entity
{
    /// <summary>
    /// Class describes entity of user
    /// </summary>
    public class UserEntity
    {
        /// <summary>
        /// Id of entity
        /// </summary>
        public int user_id { get; set; }
        
        /// <summary>
        /// Firstname of user
        /// </summary>
        public string firstname { get; set; }
        
        /// <summary>
        /// Lastname of user
        /// </summary>
        public string lastname { get; set; }

        /// <summary>
        /// Password of user
        /// </summary>
        public string password { get; set; }
        
        /// <summary>
        /// Email of user
        /// </summary>
        public string email { get; set; }
        
        /// <summary>
        /// Photo of user
        /// </summary>
        public string photo { get; set; }
        
        /// <summary>
        /// Favourite book of user
        /// </summary>
        public string favorite_book { get; set; }
        
        /// <summary>
        /// Favourite movie of user
        /// </summary>
        public string favorite_movie { get; set; }
    }
}
