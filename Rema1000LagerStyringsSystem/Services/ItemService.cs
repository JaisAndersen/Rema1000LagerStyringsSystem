﻿namespace Rema1000LagerStyringsSystem.Services
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

        }
        public void PrintItem(int id)
        {

        }
        public void UpdateItem(Item item)
        {

        }
        public void RemoveItem(string name)
        {

        }
        public Item GetItem(string name)
        {

            return null;
        }
        public List<Item> GetItems()
        {

            return null;
        }
    }
}
 