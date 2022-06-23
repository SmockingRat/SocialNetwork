using System;

namespace SocialNetwork.PLL
{
    /// <summary>
    /// Class contains new message type
    /// </summary>
    public class SucessMessage
    {
        /// <summary>
        /// Method shows success message
        /// </summary>
        /// <param name="message"> Text of message </param>
        public static void Show(string message)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message + "\n");
            Console.ForegroundColor = originalColor;    
        }

    }
}
