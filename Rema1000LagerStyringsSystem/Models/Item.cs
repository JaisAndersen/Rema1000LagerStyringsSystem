using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rema1000LagerStyringsSystem.Models
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _brand;
        private double _price;
        private StorageType _storageType;

        public Item() 
        {
            _name = Name;
            _id = Id;
            _price = Price;
            _brand = Brand;
            _storageType = StorageType;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public StorageType StorageType { get { return _storageType; } set { _storageType = value; } }
    }

}
