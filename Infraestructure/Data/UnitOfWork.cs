using Infraestructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IFishRepository Fish { get; private set;}
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Fish = new FishRepository(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
