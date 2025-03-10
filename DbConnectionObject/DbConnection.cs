using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionObject
{
    public abstract class DbConnection
    {
        /// <summary>
        /// Gets the connection string.     
        /// </summary>
        public string ConnectionString { get; }

        /// <summary>
        /// sets the timeout.
        /// </summary>
        public TimeSpan Timeout { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DbConnection"/> class.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty.");

            ConnectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(30); // Default timeout
        }

        public abstract void Open();
        public abstract void Close();
    }
}
