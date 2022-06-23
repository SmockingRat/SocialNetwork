namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Class contains message properties
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Property contains id of message entity
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Property contains content of message entity
        /// </summary>
        public string Content { get; }
        /// <summary>
        /// Property contains email of sender of message entity
        /// </summary>
        public string SenderEmail { get; }
        /// <summary>
        /// Property contains email of recirient of message entity
        /// </summary>
        public string RecipientEmail { get; }

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="id"> Id of user entity </param>
        /// <param name="content"> Content of message entity </param>
        /// <param name="senderEmail"> Email of sender </param>
        /// <param name="recipientEmail"> Email of recipient </param>
        public Message(int id, string content, string senderEmail, string recipientEmail)
        {
            this.Id = id;
            this.Content = content;
            this.SenderEmail = senderEmail;
            this.RecipientEmail = recipientEmail;
        }
    }
}
