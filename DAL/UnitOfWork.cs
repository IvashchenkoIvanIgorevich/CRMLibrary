using DAL.Interface;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {        
        public IGenericRepository<Book> Books { get; }
        public IGenericRepository<Order> Orders { get; }

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private readonly LibraryContext _context;
    }
}
