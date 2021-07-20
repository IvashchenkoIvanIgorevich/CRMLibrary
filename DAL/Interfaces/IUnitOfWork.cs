using DAL.Interface;
using DAL.Models;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Book> Books { get; }
        IGenericRepository<Order> Orders { get; }

        int Complete();
    }
}
