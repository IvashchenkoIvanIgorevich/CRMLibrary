using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRMLibrary.Services.RegisterService
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task<User> Add(string name, string email, string password);

        IEnumerable<User> GetAll();
    }
}
