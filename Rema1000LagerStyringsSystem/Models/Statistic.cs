using Rema1000LagerStyringsSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rema1000LagerStyringsSystem.Models
{
    public class Statistic
    {
        ItemService ItemService = new ItemService("Listt");
        StorageTypeService StorageType = new StorageTypeService();

        public List<Customer> customers { get; set; }
        public List<StorageType> StorageTypeList { get; set; }
        public List<Item> ItemList { get; set; }          
    }
    
}
