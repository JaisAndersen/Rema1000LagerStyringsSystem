using System.Collections.Generic;
using System.Linq;

namespace Rema1000LagerStyringsSystem
{
    public class ItemJson : IItem
    {
        string fileName = @"C:\Users\Mus\source\repos\Rema1000LagerStyringsSystem\Rema1000LagerStyringsSystem\Rema1000LagerStyringsSystem\Data\jsonItems.json";

        public void AddItem(Item item)
        {
            List<Item> items = GetAllItems();
            items.Add(item);
            jsonFileWriterItem.WriteToJson(items, fileName);
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

        public List<Item> GetAllItems()
        {
            return jsonFileReaderItem.ReadJson(fileName);
        }

        public Item GetItem(int id)
        {
            foreach (Item item in GetAllItems()) 
            {
                if(item.Id == id) return item;
            }
            return new Item();
        }

        public Item RemoveItem(int id)
        {
            List<Item> Items = GetAllItems();
            foreach (Item item in Items.ToList())
            {
                if(item.Id == id)
                    Items.Remove(item);
                jsonFileWriterItem.WriteToJson(Items, fileName);
            }
            return new Item();

        }

        public void UpdateItem(Item item)
        {
            List<Item> Items = GetAllItems();
            foreach (Item Item in Items.ToList())
            {
                if (Item.Id == item.Id)
                {
                    Item.Id = item.Id;
                    Item.StorageType = item.StorageType;
                    Item.Brand = item.Brand;
                    Item.Name = item.Name;
                    Item.Price = item.Price;

                    jsonFileWriterItem.WriteToJson(Items, fileName);
                }
            }
        }
    }
}
