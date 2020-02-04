using DataModel;
using ModelsClasses;
using Services.Interfaces;

namespace Services.Repository
{
    public class CartRepository:BaseRepository<Cart>,ICartRepository
    {
        public CartRepository(StoreContext context) : base(context) { }
    }
}
