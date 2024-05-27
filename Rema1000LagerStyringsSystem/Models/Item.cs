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
        private int _quantity;
        private StorageType _storageType;

        public Item() 
        {
            _name = Name;
            _id = Id;
            _price = Price;
            _brand = Brand;
            _storageType = StorageType;
            _quantity = Quantity;
        }

        [BindProperty]
        [Display(Name ="Id")]
        [Required(ErrorMessage = "Varen skal have et ID")]
        [Range(minimum:0,maximum:1000)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name ="Navn")]
        [Required(ErrorMessage ="Varen skal have et navn")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [Display(Name = "Pris")]
        [DataType(DataType.Currency)]
        [Range(minimum:1,maximum:10000,ErrorMessage ="Skal være være mellem 1 og 10000")]
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        [Display(Name = "Mærke navn")]
        [Required(ErrorMessage = "Varen skal have et mærke")]
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; }
        }
        [BindProperty]
        [Display(Name = "Antal varer")]
        [Required]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        [BindProperty]
        [Display(Name = "Varekategori")]
        [EnumDataType(typeof(StorageType))]
        [Required]
        public StorageType StorageType { get { return _storageType; } set { _storageType = value; } }
    }
}
