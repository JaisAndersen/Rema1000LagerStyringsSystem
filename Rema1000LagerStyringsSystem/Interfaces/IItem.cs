using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem
{
    public interface IItem
    {
        Item GetItem(int id);
        void AddItem(Item item);
        Item RemoveItem(int id);
        void UpdateItem(Item item);
        List<Item> FilterItems(string filter);
        List<Item> GetAllItems();
    }
}
