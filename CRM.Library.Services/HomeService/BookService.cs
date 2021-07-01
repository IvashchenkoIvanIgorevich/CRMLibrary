using DAL.Interface;
using DAL.Models;
using System.Collections.Generic;

namespace CRMLibrary.Services.HomeService
{
    public class BookService : IBookService
    {
        public BookService(IGenericRepository<Book> repositoryBook)
        {
            _repository = repositoryBook;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAll();
        }

        private IGenericRepository<Book> _repository;
    }
}
