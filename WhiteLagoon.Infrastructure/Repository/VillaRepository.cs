using System.Linq.Expressions;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class VillaRepository : IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Villa entity)
        {
            _db.Villas.Add(entity);
        }

        public void Update(Villa entity)
        {
            _db.Villas.Update(entity);
        }

        public void Remove(Villa entity)
        {
            _db.Villas.Remove(entity);
        }

        public IEnumerable<Villa> Get(Expression<Func<Villa, bool>>? filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Villa> GetAll(Expression<Func<Villa, bool>>? filter = null, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}