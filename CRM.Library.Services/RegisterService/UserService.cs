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

        public Task<User> Add(User newUser)
        {
            if (_repository.IsExist(eml => eml.Email.ToString().ToLower() == newUser.Email.ToLower()))
            {
                throw new InvalidOperationException($"Email \"{newUser.Email}\" already in use");
            }

            User addUser = new User()
            {
                Id = _repository.SetId(),
                Name = newUser.Name,
                Email = newUser.Email,
                Password = HashString(newUser.Password)
            };

            _repository.Add(addUser);
            _repository.Complete();

            return Task.FromResult(newUser);
        }

        public Task<User> Authenticate(string email, string password)
        {
            var foundUser = _repository
                .Find(user => string.Equals(user.Email, email, StringComparison.OrdinalIgnoreCase))
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

        public User GetById(int id)
        {
            return _repository.GetById(id);
        }

        private readonly IUserRepository _repository;
    }
}
