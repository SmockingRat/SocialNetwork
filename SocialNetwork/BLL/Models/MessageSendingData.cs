namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Class contain important data of message entity
    /// </summary>
    public class MessageSendingData
    {
        /// <summary>
        /// Property contains id of sender
        /// </summary>
        public int SenderId { get; set; }
        /// <summary>
        /// Property contains content of message
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Property contains email of recipient
        /// </summary>
        public string RecipientEmail { get; set; }
    }
}
