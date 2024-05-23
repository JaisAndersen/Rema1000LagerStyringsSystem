using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rema1000LagerStyringsSystem.Models
{
    public class Item
    {
        private int _id;
        private string _name;

        //_itemCounter skal måske undlades.

        public Item(string name) 
        {
            _name = Name;
            _id = Id;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        [StringLength(18, ErrorMessage = "Name of the item can not be longer than 18 chars")]
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        [Required(ErrorMessage = "Price required")]
        [Range(typeof(decimal), "1", "50",
        ErrorMessage = "Value for the price should be between 1 and 50 ")]

        public decimal Price { get; set; }
       
    }

}
