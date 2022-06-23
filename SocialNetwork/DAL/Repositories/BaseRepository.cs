using Dapper;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Parent class of repositories
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        /// Method looking for meaning in entities
        /// </summary>
        /// <typeparam name="T"> Parameter for objects from database </typeparam>
        /// <param name="sql"> URL of database </param>
        /// <param name="parameters"> Object </param>
        /// <returns> Connection </returns>
        protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        /// <summary>
        /// Method describes list of objects
        /// </summary>
        /// <typeparam name="T"> Parameter for objects in database </typeparam>
        /// <param name="sql"> URL of databaase </param>
        /// <param name="parameters"> Objects </param>
        /// <returns> Connection </returns>
        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        /// <summary>
        /// Methos makes connection
        /// </summary>
        /// <param name="sql"> URL of database </param>
        /// <param name="parameters"> Objcts </param>
        /// <returns> Connection </returns>
        protected int Execute(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.Execute(sql, parameters);
            }
        }

        /// <summary>
        /// Interface for connection
        /// </summary>
        /// <returns> Connection </returns>
        private IDbConnection CreateConnection()
        {
            return new SQLiteConnection("Data Source = DAL/DB/social_network_bd.db; Version = 3");
        }
    }
}
