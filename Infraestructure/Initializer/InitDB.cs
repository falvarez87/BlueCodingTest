using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Initializer
{
    public class InitDB : IInitDB
    {
        private readonly ApplicationDbContext _db;

        public InitDB(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Init()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

            }
            if (_db.Fish.Count() == 0)
            {
                Fish fish = new Fish
                {
                    Name = "Koi",
                    CreateDate = DateTime.Now,
                    Kind = "Japones"
                };
                _db.Fish.Add(fish);
                _db.SaveChanges();
            }
        }
    }
}
