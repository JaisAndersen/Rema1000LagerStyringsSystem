using Rema1000LagerStyringsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rema1000LagerStyringsSystem.Models;

using Rema1000LagerStyringsSystem.Services;


namespace Rema1000LagerStyringsSystem.Services
{
    public class StatisticService
    {
        ItemService ItemService = new ItemService("List");
        StorageTypeService StorageType = new StorageTypeService();

        private List<Customer> customers;

        private List<Item> items;
        private List<StorageType> storageTypes;
        
        
        public Item itemSearch(Item itemName)
        {
            foreach (Item item in itemList)
            {
                if (item != null)
                {
                    if (string.Equals(item.Name, itemName)) return item;
                }
            }
            return null;
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


    }
}      


   
    






       





























    

