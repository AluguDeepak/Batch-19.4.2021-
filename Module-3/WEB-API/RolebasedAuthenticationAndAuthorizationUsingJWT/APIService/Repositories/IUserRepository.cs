using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Entities;
using APIService.Models;

namespace APIService.Repositories
{
    interface IUserRepository
    {
        User ValidateUser(Login login);
        List<User> GetUsers();
        User GetUser(string Uid);
       
    }
}
