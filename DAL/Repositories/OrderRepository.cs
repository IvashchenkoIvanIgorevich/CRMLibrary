using CRMLibrary.DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace CRMLibrary.DAL.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(LibraryContext context)
            : base(context)
        {
        }        
    }
}
