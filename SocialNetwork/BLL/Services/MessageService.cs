using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entity;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.BLL.Services
{
    /// <summary>
    /// Class works with messages
    /// </summary>
    public class MessageService
    {
        /// <summary>
        /// Field of IMessageRepository interface
        /// </summary>
        IMessageRepository messageRepository;

        /// <summary>
        /// Field of IUserRepository interface
        /// </summary>
        IUserRepository userRepository;

        /// <summary>
        /// Constructor of class
        /// </summary>
        public MessageService()
        {
            userRepository = new UserRepository();
            messageRepository = new MessageRepository();
        }

        /// <summary>
        /// Method shows user's incoming messages
        /// </summary>
        /// <param name="recipientId"> Id of recipient </param>
        /// <returns> List with messages </returns>
        public IEnumerable<Message> GetIncomingMessagesByUserId(int recipientId)
        {
            var messages = new List<Message>();

            messageRepository.FindByRecipientId(recipientId).ToList().ForEach(m =>
            {
                var senderUserEntity = userRepository.FindById(m.sender_id);
                var recipientUserEntity = userRepository.FindById(m.recipient_id);

                messages.Add(new Message(m.id_message, m.content, senderUserEntity.email, recipientUserEntity.email));
            });

            return messages;
        }

        /// <summary>
        /// Method shows user's outgoing messages
        /// </summary>
        /// <param name="senderId"> Id of sender </param>
        /// <returns> List of messages </returns>
        public IEnumerable<Message> GetOutcomingMessagesByUserId(int senderId)
        {
            var messages = new List<Message>();

            messageRepository.FindBySenderId(senderId).ToList().ForEach(m =>
            {
                var senderUserEntity = userRepository.FindById(m.sender_id);
                var recipientUserEntity = userRepository.FindById(m.recipient_id);

                messages.Add(new Message(m.id_message, m.content, senderUserEntity.email, recipientUserEntity.email));
            });

            return messages;
        }

        /// <summary>
        /// Method sends messages
        /// </summary>
        /// <param name="messageSendingData"> Parameter contains important data for message sending </param>
        /// <exception cref="ArgumentNullException"> Special exception </exception>
        /// <exception cref="ArgumentOutOfRangeException"> Standart exception </exception>
        /// <exception cref="UserNotFoundExeption"> Special exception </exception>
        /// <exception cref="Exception"> Standart exception </exception>
        public void SendMessage(MessageSendingData messageSendingData)
        {
            if (String.IsNullOrEmpty(messageSendingData.Content))
                throw new ArgumentNullException();

            if (messageSendingData.Content.Length > 5000)
                throw new ArgumentOutOfRangeException();

            var findUserEntity = this.userRepository.FindByEmail(messageSendingData.RecipientEmail);
            if (findUserEntity is null) throw new UserNotFoundExeption();

            var messageEntity = new MessageEntity()
            {
                content = messageSendingData.Content,
                sender_id = messageSendingData.SenderId,
                recipient_id = findUserEntity.user_id
            };

            if (this.messageRepository.Create(messageEntity) == 0)
                throw new Exception();
        }
    }
}
