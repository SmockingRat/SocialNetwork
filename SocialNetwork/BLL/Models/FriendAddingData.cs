namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Class contain important information about friend data.
    /// </summary>
    public class FriendAddingData
    {
        /// <summary>
        /// Property contains email for adding in database
        /// </summary>
        public string friend_email { get; set; }
        /// <summary>
        /// Property user's id for adding in database
        /// </summary>
        public int user_id { get; set; }

    }
}
