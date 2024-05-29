using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem
{
    public class Statistic
    {
        //ItemService ItemService = new ItemService();
        //StorageTypeService StorageType = new StorageTypeService();

        public List<Customer> customers { get; set; }
        public List<StorageType> StorageTypeList { get; set; }
        public List<Item> ItemList { get; set; }          
    }
    
}
