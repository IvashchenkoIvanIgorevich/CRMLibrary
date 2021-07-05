using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using DAL.Interfaces;
using DAL.Models;

namespace CRMLibrary.Services.RegisterService
{
    public class UserService : IUserService
    {
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<User> Add(string name, string email, string password)
        {
            if (_unitOfWork.Users.IsExist(eml => eml.ToString().ToLower() == email.ToLower()))
            {
                throw new InvalidOperationException("Username already in use");
            }

            User newUser = new User() { Name = name, Email = email, Password = HashString(password) };

            _unitOfWork.Users.Add(newUser);

            return Task.FromResult(newUser);
        }

        public Task<User> Authenticate(string email, string password)
        {
            var foundUser = _unitOfWork.Users.Find(eml => eml.ToString().ToLower() == email.ToLower());

            if (foundUser != null)
            {
                if (((User)foundUser).Password == HashString(password))
                {
                    return Task.FromResult((User)foundUser);
                }
            }
            return null;
        }

        private string HashString(string str)
        {
            var message = Encoding.Unicode.GetBytes(str);
            var hash = new SHA256Managed();

            var hashValue = hash.ComputeHash(message);
            return Encoding.Unicode.GetString(hashValue);
        }

        private readonly IUnitOfWork _unitOfWork;
    }
}
