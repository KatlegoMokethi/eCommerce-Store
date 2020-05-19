using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        IQueryable<Order> GetOrders();
        void SaveOrder(Order order);
    }
}
