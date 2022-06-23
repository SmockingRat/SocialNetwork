using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Veiws
{
    /// <summary>
    /// Class show message sending view
    /// </summary>
    public class MessageSendingView
    {
        /// <summary>
        /// Field of UserService class
        /// </summary>
        UserService userService;

        /// <summary>
        /// Field of MessageService class
        /// </summary>
        MessageService messageService;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="messageService"> Parameter of MessageService class </param>
        /// <param name="userService"> Parameter of UserService class </param>
        public MessageSendingView(MessageService messageService, UserService userService)
        {
            this.messageService = messageService;
            this.userService = userService;
        }

        /// <summary>
        /// Method shows view
        /// </summary>
        /// <param name="user"> User datta </param>
        public void Show(User user)
        {
            var messageSendingData = new MessageSendingData();

            Console.Write("\nВведите почтовый адрес получателя: ");
            messageSendingData.RecipientEmail = Console.ReadLine();

            Console.WriteLine("\nВведите сообщение (не больше 5000 символов): ");
            messageSendingData.Content = Console.ReadLine();

            messageSendingData.SenderId = user.Id;

            try
            {
                messageService.SendMessage(messageSendingData);

                SucessMessage.Show("Сообщение успешно отправлено!");

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundExeption)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }
            catch (ArgumentOutOfRangeException)
            {
                AlertMessage.Show("Слишком длинное сообщение!");
            }
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при отправке сообщения!");
            }
        }
    }
}
