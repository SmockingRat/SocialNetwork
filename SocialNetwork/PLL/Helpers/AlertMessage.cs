using System;

namespace SocialNetwork.PLL.Helpers
{
    /// <summary>
    /// Class contain new type of message
    /// </summary>
    public class AlertMessage
    {
        /// <summary>
        /// Show alert message
        /// </summary>
        /// <param name="message"> Text of message </param>
        public static void Show(string message)
        {
            ConsoleColor origColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message + "\n");
            Console.ForegroundColor = origColor;
        }
    }
}
