namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Class contains user's data for registration
    /// </summary>
    public class UserRegistrationData
    {
        /// <summary>
        /// User's firtname
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User's lastname
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// User's password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }
    }
}