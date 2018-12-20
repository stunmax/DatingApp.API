using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;


namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> RegiserAsync(User user, string passoword);
        Task<User> Login(string username, string passoword);
        Task<bool> UserExits(string username);
        
    }
}
