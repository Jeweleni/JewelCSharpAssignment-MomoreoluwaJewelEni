using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionObject
{
    public class SqlConnection : DbConnection
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlConnection"/> class.
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlConnection(string connectionString) : base(connectionString) { }


        /// <summary>
        /// Opens the connection.
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Opening SQL Server connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL Server connection...");
        }
    }
}
