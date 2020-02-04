using DataModel;
using ModelsClasses;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services.Repository
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
       
        public BrandRepository(StoreContext context) : base(context)
        {
           
        }
        
        //public new IEnumerable<Brand> GetAll()
        //{
        //    //return Context.Set<Brand>().ToList();
        //    StoreContext list = new StoreContext();
        //    return list.Brands.Select(x => x).ToList();
        //}
    }
}
