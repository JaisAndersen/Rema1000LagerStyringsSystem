using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rema1000LagerStyringsSystem.Models
{
    public class StorageType
    {
        private int _id;
        private string _name;
        
        public StorageType()
        {
            _id = Id;
            _name = Name;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        [StringLength(30, ErrorMessage = "Name of the storage type can not be longer than 30 chars")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }   
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
