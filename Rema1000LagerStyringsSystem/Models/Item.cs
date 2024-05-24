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

        public Item() 
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
        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public decimal Price { get; set; }
       
    }

}
