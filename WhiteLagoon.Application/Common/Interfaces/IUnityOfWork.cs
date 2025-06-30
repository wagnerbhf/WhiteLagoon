namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IUnityOfWork
    {
        IVillaRepository Villa { get; }
        IVillaNumberRepository VillaNumber { get; }
        IAmenityRepository Amenity { get; }
        void Save();
    }
}