using APIService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Repositories;
using APIService.Models;
namespace APIService.Services
{
    public class UserService : IUserService
    {
        UserRepository userRepository = new UserRepository();
        public User GetUser(string Uid)
        {
            return userRepository.GetUser(Uid);
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public User ValidateUser(Login login)
        {
            return userRepository.ValidateUser(login);
        }
    }
}
