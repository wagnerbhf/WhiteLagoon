using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Services.Interface
{
    public interface IVillaService
    {
        IEnumerable<Villa> GetAllVillas();
        Villa GetVillaById(int id);
        void CreateVilla(Villa villa, string webRootPath);
        void UpdateVilla(Villa villa, string webRootPath);
        bool DeleteVilla(int id, string webRootPath);
        IEnumerable<Villa> GetVillasAvailabilityByDate(int nights, DateOnly checkInDate);
        bool IsVillaAvailableByDate(int villaId, int nights, DateOnly checkInDate);
    }
}