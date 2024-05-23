using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Rema1000LagerStyringsSystem.Models;
using Microsoft.AspNetCore.Http.Features;

namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemCreateModel : PageModel
    {
        private IItem repo;
        [BindProperty]
        public Item item { get; set; }
    public ItemCreateModel(Iitem repostitory) 
        { 
            repo = repostitory;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (repo.GetAllItems().Count < Item.ItemId)
            {
                repo.AddPizza(Item);
            }
            repo.UpdateItem(Item);
            return RedirectToPage("GetAllItems");
        }
        public IActionResult OnGet()
        {
                    return Page();
        }


        }

    }


}
