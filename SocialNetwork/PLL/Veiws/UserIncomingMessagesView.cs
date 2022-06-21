using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Veiws
{
    public class UserIncomingMessageView
    {
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
