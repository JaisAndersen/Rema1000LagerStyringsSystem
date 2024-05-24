using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Rema1000LagerStyringsSystem.Interface
{
    public interface IItem
    {
        List<Item> GetAllItems();
        void AddItem(Item item);
        Item GetItem(int id) 
        {
            return GetAllItems()[id];
        }
        public void RemoveItem(int id) 
        {
            GetAllItems().RemoveAt(id);
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
    }
}
