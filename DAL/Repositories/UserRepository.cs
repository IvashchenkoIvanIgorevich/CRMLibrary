using CRMLibrary.DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CRMLibrary.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(LibraryContext context)
            : base(context)
        {
        }

        public User Add(string name, string email, string password)
        {
            _context.User.Add(new User { Name = name, Email = email, Password = password });

            return _context?.User?.FirstOrDefault(user => user.Email == email);
        }
    }
}
