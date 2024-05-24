using Rema1000LagerStyringsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rema1000LagerStyringsSystem.Services;
using Rema1000LagerStyringsSystem.Interface;


namespace Rema1000LagerStyringsSystem.Services
{
    public class StatisticService : IStatistic
    {
        ItemService ItemService = new ItemService();
        StorageTypeService StorageType = new StorageTypeService();

        private List<Customer> customers;

        private List<Item> items;
        private List<StorageType> storageTypes;
        
        
        public Item itemSearch(Item itemName)
        {
            foreach (Item item in items)
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


   
    






       





























    

