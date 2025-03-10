using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionObject
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _instruction;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbCommand"/> class.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="instruction"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public DbCommand(DbConnection connection, string instruction)
        {
            _connection = connection ?? throw new InvalidOperationException("Connection cannot be null.");
            _instruction = string.IsNullOrWhiteSpace(instruction) ? throw new InvalidOperationException("Instruction cannot be null or empty.") : instruction;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        public void Execute()
        {
            _connection.Open();
            Console.WriteLine($"Executing command: {_instruction}");
            _connection.Close();
        }
    }
}
