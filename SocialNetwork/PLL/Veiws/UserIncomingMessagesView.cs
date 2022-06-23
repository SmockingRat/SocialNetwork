using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class shows incoming messages
    /// </summary>
    public class UserIncomingMessageView
    {
        /// <summary>
        /// Method shows view
        /// </summary>
        /// <param name="incomingMessages"></param>
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("\nВходящие сообщения");

            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("\nВходящих сообщения нет");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("\nОт кого: {0}. Текст сообщения: {1}\n", message.SenderEmail, message.Content);
            });
        }
    }
}
