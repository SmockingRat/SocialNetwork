using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class shows user's outgoing messages
    /// </summary>
    public class UserOutcomingMessageView
    {
        /// <summary>
        /// Method shows view
        /// </summary>
        /// <param name="outcomingMessages"> List of messages </param>
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            Console.WriteLine("\nИсходящие сообщения");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("Исходящих сообщений нет");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("Кому: {0}. Текст сообщения: {1}\n", message.RecipientEmail, message.Content);
            });
        }
    }
}
