using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Rema1000LagerStyringsSystem
{
    public enum StorageType
    {
        [Display(Name = "Majeri")]
        Majeri = 0,
        [Display(Name = "Kød")]
        Kød = 1,
        [Display(Name = "Frost")]
        Frost = 2,
        [Display(Name = "Frugt")]
        Frugt = 3,
        [Display(Name = "Grønt")]
        Grønt = 4
    }
}
