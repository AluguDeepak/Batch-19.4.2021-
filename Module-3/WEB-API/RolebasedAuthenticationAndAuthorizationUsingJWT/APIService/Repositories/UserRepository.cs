using APIService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Repositories;
using APIService.Models;

namespace APIService.Repositories
{
    public class UserRepository : IUserRepository
    {
        AuthenticationDBContext authenticationDB = new AuthenticationDBContext();
        public User GetUser(string Uid)
        {
            return authenticationDB.Users.Find(Uid);
        }

        public List<User> GetUsers()
        {
            return authenticationDB.Users.ToList();
        }

        public User ValidateUser(Login login)
        {
            return authenticationDB.Users.SingleOrDefault(u => u.Username == login.Uname && u.Password == login.Pwd);
        }
    }
}
