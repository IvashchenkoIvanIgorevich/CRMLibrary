using DAL.Models;
using System.Collections.Generic;

namespace CRMLibrary.Services.HomeService
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
    }
}
