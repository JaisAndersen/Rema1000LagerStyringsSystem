using System.Collections.Generic;
using System.Linq;
namespace Rema1000LagerStyringsSystem
{
    public class ItemService : IItem
    {
        List<Item> itemList;
        public ItemService()
        {
            itemList = new List<Item>();
        }
        public Item GetItem(int id)
        {
            foreach (Item item in itemList)
            {
                if (item.Id == id)
                    return item;
            }
            return new Item();
        }
        public void AddItem(Item item)
        {
            if (!(itemList.Contains(item)))
                itemList.Add(item);
        }

        public void RemoveItem(int id)
        {
            foreach (Item item in itemList.ToList())
            {
                if (item.Id == id)
                    itemList.Remove(item);
            }
        }

        public void UpdateItem(Item item)
        {
            foreach (Item Item in itemList)
            {
                if (Item.Id == item.Id)
                {
                    Item.Id = item.Id;
                    Item.StorageType = item.StorageType;
                    Item.Brand = item.Brand;
                    Item.Name = item.Name;
                    Item.Price = item.Price;
                    Item.Quantity = item.Quantity;
                }
            }
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
            return itemList;
        }

    }
}