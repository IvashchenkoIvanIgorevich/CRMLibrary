using DAL.Interface;
using DAL.Models;

namespace CRMLibrary.DAL.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User Add(string name, string email, string password);
        int SetId();
    }
}
