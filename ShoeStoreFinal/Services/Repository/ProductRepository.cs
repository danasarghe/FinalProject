using DataModel;
using ModelsClasses;
using Services.Interfaces;

namespace Services.Repository
{
    public class ProductRepository:BaseRepository<Product>,IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context) { }
    }
}
