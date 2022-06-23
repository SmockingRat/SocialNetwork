using SocialNetwork.DAL.Entity;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Interface of message repository
    /// </summary>
    public interface IMessageRepository
    {
        /// <summary>
        /// Mthod creates new entity
        /// </summary>
        /// <param name="messageEntity"> Class contains user entity </param>
        /// <returns> Connection </returns>
        int Create(MessageEntity messageEntity);

        /// <summary>
        /// Method looking for sender by id
        /// </summary>
        /// <param name="senderId"> Sender id </param>
        /// <returns> List of objects </returns>
        IEnumerable<MessageEntity> FindBySenderId(int senderId);
        
        /// <summary>
        /// Method looking for recipient by id
        /// </summary>
        /// <param name="recipientId"> Recipient id </param>
        /// <returns> List of objects </returns>
        IEnumerable<MessageEntity> FindByRecipientId(int recipientId);
        
        /// <summary>
        /// Method deletes entity by id
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        int DeleteById(int messageId);
    }
}
