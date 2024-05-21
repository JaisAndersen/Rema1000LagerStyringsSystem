using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rema1000LagerStyringsSystem.Models;

namespace Rema1000LagerStyringsSystem.Services
{
    public class StorageTypeService
    {
        private List<StorageType> storageTypes;
        private List<Item> items;
        private string fileName = "";

        public void CreateStorageType() 
        {
            
        }
        public void RemoveStorageType(int id) 
        {
            storageTypes.Remove(storageTypes[id]);
        }
        public StorageType StorageTypeSearch(string storageTypeName) 
        {
            foreach (StorageType storageType in storageTypes)
            {
                if (storageType != null)
                {
                    if (string.Equals(storageType.Name, storageTypeName)) return storageType;
                }
            }
            return null;
        }
    }
}
