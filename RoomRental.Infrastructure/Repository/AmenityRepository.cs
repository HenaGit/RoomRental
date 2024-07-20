using RoomRental.Application.Common.Interfaces;
using RoomRental.Domain.Entities;
using RoomRental.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRental.Infrastructure.Repository
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        private readonly ApplicationDbContext _db;

        public AmenityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Amenity entity)
        {
            _db.Amenities.Update(entity);
        }
    }
}
