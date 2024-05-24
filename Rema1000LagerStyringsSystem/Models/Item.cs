using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Rema1000LagerStyringsSystem
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

        [BindProperty]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name ="Vare navn")]
        [Required(ErrorMessage ="Varen skal have et navn!")]
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
        [Display(Name = "Mærke navn")]
        [Required(ErrorMessage = "Varen skal have et mærke!")]
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; }
        }
        [BindProperty]
        [EnumDataType(typeof(StorageType))]
        public StorageType StorageType { get { return _storageType; } set { _storageType = value; } }
        public enum StorageTypes
        {
            [Display(Name = "Majeri")]
            Majeri = 0,
            [Display(Name = "Kød")]
            Kød = 1,
            [Display(Name = "Frost")]
            Frost = 2,
            [Display(Name = "Frugt")]
            Frug = 3,
            [Display(Name = "Grønt")]
            Grønt = 4
        }
    }

}
