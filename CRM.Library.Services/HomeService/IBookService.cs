using DAL.Models;
using System.Collections.Generic;

namespace CRMLibrary.Services.HomeService
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        void Edit(Book editBook);
    }
}
