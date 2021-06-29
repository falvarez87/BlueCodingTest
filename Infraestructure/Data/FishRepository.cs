using ApplicationCore;
using Infraestructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data
{
    public class FishRepository : Repository<Fish>, IFishRepository
    {
        public FishRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
