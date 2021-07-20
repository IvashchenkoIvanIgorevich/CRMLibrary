using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {        
        public BookRepository(LibraryContext context)
            :base(context)
        {
        }

        public IEnumerable<Book> GetPopularBooks(int count)
        {
            return (IEnumerable<Book>)_context.Order
                .GroupJoin(_context.Book, o => o.IdBook, b => b.Id, (o, b) => new { o, b, countBook = b.Count() })
                .OrderByDescending(or => or.countBook)
                .Take(count)
                .Select(b1 => b1.b);
        }
    }
}
