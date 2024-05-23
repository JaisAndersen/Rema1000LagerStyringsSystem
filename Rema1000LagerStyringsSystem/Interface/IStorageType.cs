using System.Collections.Generic;
using Rema1000LagerStyringsSystem.Models;

namespace Rema1000LagerStyringsSystem.Interface
{
    public interface IStorageType
    {
        List<StorageType> GetAllStorageTypes();
        void AddStorageType(StorageType storageType);
        StorageType GetStorageType(int id);
    }
}
