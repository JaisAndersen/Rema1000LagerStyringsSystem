using Rema1000LagerStyringsSystem.Models;
using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem.Interface
{
    public interface IItem
    {
        List<Item> GetAllItems();
        void AddItem(Item item);
        Item GetItem(int id);
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
    }
}
