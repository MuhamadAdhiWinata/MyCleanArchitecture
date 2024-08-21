using Core.Entities;
using System.Collections.Generic;

namespace Core.Application.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(int id);
        IEnumerable<User> GetAllUsers();
    }
}
