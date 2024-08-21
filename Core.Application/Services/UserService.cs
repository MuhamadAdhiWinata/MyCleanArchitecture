using Core.Application.Interfaces;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUser(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }
    }
}
