namespace SocialNetwork.DAL.Entity
{
    /// <summary>
    /// Class describes user entity
    /// </summary>
    public class MessageEntity
    {
        /// <summary>
        /// Id of message entity
        /// </summary>
        public int id_message { get; set; }
        
        /// <summary>
        /// Content of message
        /// </summary>
        public string content { get; set; }
        
        /// <summary>
        /// Id of sender
        /// </summary>
        public int sender_id { get; set; }
        
        /// <summary>
        /// Id of recipient
        /// </summary>
        public int recipient_id { get; set; }
    }
}
