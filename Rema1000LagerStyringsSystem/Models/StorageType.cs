using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Rema1000LagerStyringsSystem
{
    public enum StorageType
    {
        [Display(Name = "Mejeri")]
        Mejeri = 0,
        [Display(Name = "Kød")]
        Kød = 1,
        [Display(Name = "Frost")]
        Frost = 2,
        [Display(Name = "Frugt")]
        Frugt = 3,
        [Display(Name = "Grønt")]
        Grønt = 4,
        [Display(Name ="Tørkolonial")]
        Tørkolonial = 5,
        [Display(Name = "Drikkevarer")]
        Drikkevarer = 6,
        [Display(Name = "Dyremad")]
        Dyremad = 7,
        [Display(Name = "Konserves")]
        Konserves = 8,
        [Display(Name = "Rengøring")]
        Rengøring = 9,
        [Display(Name = "Tobak")]
        Tobak = 10,
        [Display(Name = "Brød og kage")]
        BrødOgKage = 11,
        [Display(Name = "Konfekture")]
        Konfekture = 12
    }
}
