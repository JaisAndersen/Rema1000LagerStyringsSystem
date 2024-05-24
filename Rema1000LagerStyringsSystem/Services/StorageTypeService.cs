﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rema1000LagerStyringsSystem.Interface;
using Rema1000LagerStyringsSystem.Models;

namespace Rema1000LagerStyringsSystem.Services
{
    public class StorageTypeService : IStorageType
    {
        private StorageType StorageType = new StorageType();
        private List<Item> items;
        private string fileName = "";
        private List<StorageType> storageTypeList;

        public StorageTypeService() 
        { 
            storageTypeList = new List<StorageType>();
            storageTypeList.Add(new StorageType() { Id = 1, Name="Majeri"});
        }
      
        public List<StorageType> StorageTypeList
        {
            get { return storageTypeList; }
        }

        public void CreateStorageType(StorageType storageType) 
        {
            storageTypeList.Add(storageType);                    
        }

        public void RemoveStorageType(string Name)
        {
            StorageTypeList.RemoveAll(StorageType => StorageType.Name == Name);
        }

         public void UpdateStorageType(StorageType storageType)
        {
            if (storageType != null) 
            { 
                foreach (var e in StorageTypeList) 
                {
                    if (e.Name == storageType.Name)
                    {
                        e.Name = storageType.Name;
                        e.Id = storageType.Id;
                    }
                }

            }
        }

        public StorageType StorageTypeSearch(string storageTypeName) 
        {
            foreach (StorageType storageType in StorageTypeList)
            {
                if (storageType != null)
                {
                    if (string.Equals(storageType.Name, storageTypeName)) return storageType;
                }
            }
            return null;
        }

        public List<StorageType> GetAllStorageTypes()
        {
            return storageTypeList;
        }

        public void AddStorageType(StorageType storageType)
        {
            storageTypeList.Add(storageType);
        }

        public StorageType GetStorageType(int id)
        {
            return StorageTypeList[id];
        }
    }
}
