using LibraryProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LibraryProject.ConnectionString;

namespace LibraryProject.Repositories
{
    public class UserRepository
    {
        public UserDto ValidateUser(string  username, string password)
        {
            using (var conn = DatabaseConnectionString.GetConnection())
            {
                var user = conn.QueryFirstOrDefault<UserDto>(@"
            SELECT TOP 1 UserId, UserName, UserPassword
            FROM Users
            WHERE UserName = @Username AND UserPassword = @Password",
            new
            {
                Username = username,
                Password = password
            });
                return user;
            }
        }
    }
}
