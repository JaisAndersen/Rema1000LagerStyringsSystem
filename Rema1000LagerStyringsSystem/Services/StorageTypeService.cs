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

        public void PrintStorageType() 
        {
            foreach (StorageType storageType in storageTypes) 
            {
                Console.WriteLine(storageType);
            }
        }
        public void RemoveStorageType(int id) 
        {
            storageTypes.Remove();
        }
        public void StorageTypeSearch() 
        {
            
        }
        public void CreateStorageType() 
        {
            
        }

    }
}
