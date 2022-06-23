using System.Collections.Generic;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Class contains user entity data
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id of user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Firstname of user
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Lastname of user
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
        /// <summary>
        /// Photo in user's account
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// User's favourite movie name
        /// </summary>
        public string FavoriteMovie { get; set; }
        /// <summary>
        /// User's favourite book name
        /// </summary>
        public string FavoriteBook { get; set; }
        /// <summary>
        /// User's incoming mesages
        /// </summary>
        public IEnumerable<Message> IncomingMessages { get; }
        /// <summary>
        /// User's outgoing mesages
        /// </summary>
        public IEnumerable<Message> OutgoingMessages { get; }

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="id"> User's id </param>
        /// <param name="firstname"> User's firstname </param>
        /// <param name="lastname"> User's lastname </param>
        /// <param name="password"> User's password </param>
        /// <param name="email"> User's email </param>
        /// <param name="photo"> User's photo </param>
        /// <param name="favoriteMovie"> User's favourite movie </param>
        /// <param name="favoriteBook"> User's favourite book </param>
        /// <param name="incomingMessages"> User's incoming messages </param>
        /// <param name="outcomingMessages"> User's outgoing messages </param>
        public User(int id, string firstname, string lastname, string password, string email, string photo, string favoriteMovie, string favoriteBook, IEnumerable<Message> incomingMessages, IEnumerable<Message> outcomingMessages)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Password = password;
            Email = email;
            Photo = photo;
            FavoriteMovie = favoriteMovie;
            FavoriteBook = favoriteBook;
            IncomingMessages = incomingMessages;
            OutgoingMessages = outcomingMessages;

        }

    }
}
