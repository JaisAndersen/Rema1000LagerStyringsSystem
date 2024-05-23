using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using Rema1000LagerStyringsSystem.Models;
using Microsoft.VisualBasic;
using Rema1000LagerStyringsSystem.Interface;

namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemDeleteModel : PageModel
    {
        [BindProperty]
        public Item Item { get; set; }
        ItemService ItemService;
        private IItem repo;

        public ItemDeleteModel(ItemService item)
        {
            ItemService = item;
        }
        public IActionResult OnGet(int Id)
        {
            Item = ItemService.itemSearch(Id);
            return Page();
        }

        public IActionResult OnPost(string name)
        {
            ItemService.RemoveItem(name);
            return RedirectToPage("Index");
        }
    }
}

