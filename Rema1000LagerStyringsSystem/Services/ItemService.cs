namespace Rema1000LagerStyringsSystem.Services
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rema1000LagerStyringsSystem.Models;

    public class ItemService
    {
        private string fileName;
        private Item Item;
        List<Item> itemList;

        public ItemService(string fileName)
        {
            this.fileName = fileName;
        }

        public List<Item> ItemList
        {
            get { return itemList; }
        }

        public void CreateItem(Item item)
        {
            itemList.Add(item);
        }
        
        public void UpdateItem(Item item)
        {
            if (item != null)
            {
                foreach (var e in itemList)
                {
                    if (e.Name == item.Name)
                    {
                        e.Name = item.Name;
                        e.Id = item.Id;
                    }
                }
            }
        }
        public void RemoveItem(string name)
        {
            itemList.RemoveAll(item => item.Name == name);
        }

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
    }
}
 
