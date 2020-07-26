using System.Collections.Generic;
using Commander.Entities;
using Commander.Models;


namespace Commander.Repository
{
    public interface IUserRepo
    {
        bool SaveChanges();
        User Login(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(User user);
    }
}

