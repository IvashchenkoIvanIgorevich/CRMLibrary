using DAL.Interface;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace CRMLibrary.Services.HomeService
{
    public class BookService : IBookService
    {
        public BookService(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.Books.GetAll();
        }

        private readonly IUnitOfWork _repository;
    }
}
