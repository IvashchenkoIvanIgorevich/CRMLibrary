using CRMLibrary.DAL.Interfaces;
using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
