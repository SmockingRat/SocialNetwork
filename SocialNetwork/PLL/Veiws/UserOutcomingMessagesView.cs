﻿using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Veiws
{
    public class UserOutcomingMessageView
    {
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
