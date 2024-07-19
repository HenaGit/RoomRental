﻿using RoomRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoomRental.Application.Common.Interfaces
{
    public interface IVillaRepository : IRepository<Villa>
    {
        //IEnumerable<Villa> GetAll(Expression<Func<Villa, bool>>? filter = null, string? includeProperties = null);
        //Villa Get(Expression<Func<Villa, bool>> filter, string? includeProperties = null);
        //void Add(Villa entity);
        // void Remove(Villa entity);
        void Update(Villa entity);
        void Save();
    }
}
