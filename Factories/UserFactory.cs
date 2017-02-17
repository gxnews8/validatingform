using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using validatingForm.Models;
 
namespace DapperApp.Factory
{
    public class UserFactory : IFactory<User>
    {
        private string connectionString;
        public UserFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=8889;database=mydb;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
    }
}
