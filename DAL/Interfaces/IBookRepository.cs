using DAL.Interface;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        IEnumerable<Book> GetPopularBooks(int count);
    }
}
