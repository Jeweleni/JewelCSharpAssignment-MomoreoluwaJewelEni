using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionObject
{
    public class OracleConnection : DbConnection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleConnection"/> class.
        /// </summary>
        /// <param name="connectionString"></param>
        public OracleConnection(string connectionString) : base(connectionString) { }



        /// <summary>
        /// Opens the connection.
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }
    }
}
