using CRMLibrary.DAL.Interfaces;
using CRMLibrary.DAL.Repositories;
using DAL.Interface;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {        
        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        public IBookRepository Books
        {
            get
            {
                return _books == null ? new BookRepository(_context) : _books;
            }
        }

        public IOrderRepository Orders { get => _orders == null ? new OrderRepository(_context) : _orders; }
        public IUserRepository Users { get => _users == null ? new UserRepository(_context) : _users; }        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private readonly LibraryContext _context;
        private readonly IBookRepository _books;
        private readonly IOrderRepository _orders;
        private readonly IUserRepository _users;
    }
}
