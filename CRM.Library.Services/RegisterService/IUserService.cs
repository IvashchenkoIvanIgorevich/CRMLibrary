using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRMLibrary.Services.RegisterService
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task<User> Add(User newUser);

        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
