﻿using System.Linq.Expressions;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IVillaRepository
    {
        IEnumerable<Villa> GetAll(Expression<Func<Villa, bool>>? filter = null, string? includeProperties = null);
        IEnumerable<Villa> Get(Expression<Func<Villa, bool>>? filter, string? includeProperties = null);
        void Add(Villa villa);
        void Update(Villa villa);
        void Remove(Villa villa);
        void Save();
    }
}