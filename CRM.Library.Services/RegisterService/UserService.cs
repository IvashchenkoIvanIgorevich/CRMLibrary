using CRMLibrary.DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRMLibrary.Services.RegisterService
{
    public class UserService : IUserService
    {
        public UserService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public Task<User> Add(string name, string email, string password)
        {
            if (_repository.IsExist(eml => eml.Email.ToString().ToLower() == email.ToLower()))
            {
                throw new InvalidOperationException("Username already in use");
            }

            User newUser = new User()
            {
                Id = _repository.SetId(),
                Name = name,
                Email = email,
                Password = HashString(password)
            };

            _repository.Add(newUser);
            _repository.Complete();

            return Task.FromResult(newUser);
        }

        public Task<User> Authenticate(string email, string password)
        {
            var foundUser = _repository
                .Find(user => user.Email.ToLower() == email.ToLower())
                .FirstOrDefault();

            if (foundUser != null)
            {
                if (foundUser.Password == HashString(password))
                {
                    return Task.FromResult(foundUser);
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

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        private readonly IUserRepository _repository;
    }
}
