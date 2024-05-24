using System.Collections.Generic;
using System.Linq;

namespace Rema1000LagerStyringsSystem
{
    //public class StorageTypeService : IStorageType
    //{
    //    List<StorageType> storageTypes;
    //    public StorageTypeService() 
    //    {
    //        storageTypes = new List<StorageType>();
    //    }
    //    public StorageType GetStorageType(int id)
    //    {
    //        foreach (StorageType storageType in storageTypes)
    //        {
    //            if (storageType.Id == id)
    //                return storageType;
    //        }
    //        return new StorageType();
    //    }
    //    public void AddStorageType(StorageType storageType)
    //    {
    //        if (!(storageTypes.Contains(storageType)))
    //            storageTypes.Add(storageType);
    //    }
    //    public StorageType RemoveStorageType(int id)
    //    {
    //        foreach (StorageType storageType in storageTypes.ToList())
    //        {
    //            if (storageType.Id == id)
    //                storageTypes.Remove(storageType);
    //        }
    //        return new StorageType();
    //    }
    //    public void UpdateStorageType(StorageType StorageType)
    //    {
    //        foreach (StorageType storageType in storageTypes)
    //        {
    //            if (storageType.Id == StorageType.Id)
    //            {
    //                storageType.Id = StorageType.Id;
    //                storageType.Name = StorageType.Name;
    //            }
    //        }
    //    }
    //    public List<StorageType> FilterStorageType(string filter)
    //    {
    //        List<StorageType> filteredList = new List<StorageType>();
    //        foreach (StorageType storageType in GetAllStorageTypes())
    //        {
    //            if (storageType.Name.Contains(filter, System.StringComparison.OrdinalIgnoreCase))
    //            {
    //                filteredList.Add(storageType);
    //            }
    //        }
    //        return filteredList;
    //    }

    //    public List<StorageType> GetAllStorageTypes()
    //    {
    //        return storageTypes;
    //    }
    //}
}
