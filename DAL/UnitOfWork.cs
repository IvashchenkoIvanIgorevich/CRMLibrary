using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {        
        public IBookRepository Books { get; private set; }

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
            Books = new BookRepository(context);
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
