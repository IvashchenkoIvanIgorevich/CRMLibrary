using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace CRMLibrary.Services.HomeService
{
    public class BookService : IBookService
    {
        public BookService(IBookRepository bookRepository)
        {
            _repository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public void Edit(Book editBook)
        {
            _repository.Update(editBook);
            _repository.Complete();
        }

        public Book GetById(int? id)
        {
            return _repository.GetById(id);
        }

        private readonly IBookRepository _repository;
    }
}
