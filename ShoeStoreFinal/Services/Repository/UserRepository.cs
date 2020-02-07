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
    public class  UserRepository:BaseRepository<User>,IUserRepository
    {
        public UserRepository(StoreContext context) : base(context) { }
    }
}
