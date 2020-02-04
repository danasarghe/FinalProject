using DataModel;
using ModelsClasses;
using Services.Interfaces;

namespace Services.Repository
{
    public class GenreRepository:BaseRepository<Genre>,IGenreRepository
    {
        public GenreRepository(StoreContext context) : base(context) { }
    }
}
