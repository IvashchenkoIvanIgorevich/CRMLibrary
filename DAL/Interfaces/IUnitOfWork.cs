using CRMLibrary.DAL.Interfaces;
using DAL.Interface;
using DAL.Models;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IOrderRepository Orders { get; }
        IUserRepository Users { get; }

        int Complete();
    }
}
