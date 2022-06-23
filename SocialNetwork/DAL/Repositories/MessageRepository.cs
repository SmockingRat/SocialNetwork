using SocialNetwork.DAL.Entity;
using System.Collections.Generic;


namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Class of message repository
    /// </summary>
    public class MessageRepository:BaseRepository, IMessageRepository
    {
        /// <summary>
        /// Mthod creates new entity
        /// </summary>
        /// <param name="messageEntity"> Class contains user entity </param>
        /// <returns> Connection </returns>
        public int Create(MessageEntity messageEntity)
        {
            return Execute(@"insert into messages(content, sender_id, recipient_id) 
                             values(:content,:sender_id,:recipient_id)", messageEntity);
        }

        /// <summary>
        /// Method looking for sender by id
        /// </summary>
        /// <param name="senderId"> Sender id </param>
        /// <returns> List of objects </returns>
        public IEnumerable<MessageEntity> FindBySenderId(int senderId)
        {
            return Query<MessageEntity>("select * from messages where sender_id = :sender_id", new { sender_id = senderId });
        }

        /// <summary>
        /// Method looking for recipient by id
        /// </summary>
        /// <param name="recipientId"> Recipient id </param>
        /// <returns> List of objects </returns>
        public IEnumerable<MessageEntity> FindByRecipientId(int recipientId)
        {
            return Query<MessageEntity>("select * from messages where recipient_id = :recipient_id", new { recipient_id = recipientId });
        }

        /// <summary>
        /// Method deletes entity by id
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        public int DeleteById(int messageId)
        {
            return Execute("delete from messages where message_id = :id", new { id = messageId });
        }
    }
}
