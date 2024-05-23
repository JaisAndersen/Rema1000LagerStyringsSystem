using System;
using System.Collections.Generic;
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

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }       

    }

}
