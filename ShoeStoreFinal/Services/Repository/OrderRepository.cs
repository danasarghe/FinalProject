using DataModel;
using ModelsClasses;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class OrderRepository:BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(StoreContext context) : base(context) { }
    }
}
