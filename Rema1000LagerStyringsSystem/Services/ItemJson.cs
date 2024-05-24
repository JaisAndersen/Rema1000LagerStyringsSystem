using Rema1000LagerStyringsSystem.Interface;
using Rema1000LagerStyringsSystem.JsonHelpers;
using Rema1000LagerStyringsSystem.Models;
using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem.Services
{
    public class ItemJson : IItem
    {
        string fileName = @"C:\Users\mstac\source\repos\Rema1000LagerStyringsSystem\Rema1000LagerStyringsSystem\Rema1000LagerStyringsSystem\Data\jsonItems.json";
        private List<Item> Items;
        public void AddItem(Item item)
        {
            Items = jsonFileReaderItem.ReadJson(fileName);
            Items.Add(item);
            JsonHelpers.jsonFileWriterItem.WriteToJson(Items, fileName);
        }
        public void RemoveItem(int id)
        {
            Items = jsonFileReaderItem.ReadJson(fileName);
            Items.RemoveAt(id-1);
            JsonHelpers.jsonFileWriterItem.WriteToJson(Items, fileName);
        }
        public List<Item> GetAllItems()
        {
            return JsonHelpers.jsonFileReaderItem.ReadJson(fileName);
        }
        public List<Item> FilterItems(string filter)
        {
            List<Item> filteredList = new List<Item>();
            foreach (Item item in GetAllItems())
            {
                if (item.Name.Contains(filter, System.StringComparison.OrdinalIgnoreCase))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
        public Item GetItem(int id)
        {
            return GetAllItems()[id-1];
        }
    }
}
