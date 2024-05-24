using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem
{
    public interface IStorageType
    {
        StorageType GetStorageType(int id);
        void AddStorageType(StorageType storageType);
        StorageType RemoveStorageType(int id);
        void UpdateStorageType(StorageType storageType);
        List<StorageType> FilterStorageType(string filter);
        List<StorageType> GetAllStorageTypes();
    }
}
