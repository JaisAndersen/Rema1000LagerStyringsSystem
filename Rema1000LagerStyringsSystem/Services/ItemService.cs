namespace Rema1000LagerStyringsSystem.Services
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using Rema1000LagerStyringsSystem.Interface;
    using Rema1000LagerStyringsSystem.Models;

    public class ItemService : IItem
    {
        private string fileName = @"C:\Users\Mus\source\repos\Rema1000LagerStyringsSystem\Rema1000LagerStyringsSystem\Data\jsonItems.json";
        private Item Item;
        List<Item> itemList;

        public ItemService()
        {

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
        public Item itemSearch(int Id)
        {
            foreach (Item item in itemList)
            {
                if (item != null)
                {
                    if (string.Equals(item.Name, Id)) return item;
                }
            }
            return null;
        }

        public List<Item> GetAllItems()
        {
            return itemList;
        }

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public Item GetItem(int id)
        {
            return itemList[id-1];
        }
        public Item item { get { return item; } }
    }
}
 
