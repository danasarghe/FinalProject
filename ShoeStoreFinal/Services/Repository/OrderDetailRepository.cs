using DataModel;
using ModelsClasses;
using Services.Interfaces;

namespace Services.Repository
{
    public class OrderDetailRepository:BaseRepository<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(StoreContext context) : base(context) { }
    }
}
