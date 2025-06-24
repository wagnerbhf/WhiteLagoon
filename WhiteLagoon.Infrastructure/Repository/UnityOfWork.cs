using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext _db;
        public IVillaRepository Villa { get; private set; }
        public IVillaNumberRepository VillaNumber { get; private set; }

        public UnityOfWork(ApplicationDbContext db)
        {
            _db = db;
            Villa = new VillaRepository(_db);
            VillaNumber = new VillaNumberRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}