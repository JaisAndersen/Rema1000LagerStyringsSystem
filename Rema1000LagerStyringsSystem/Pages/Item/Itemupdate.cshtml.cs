using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using Rema1000LagerStyringsSystem.Models;

namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemUpdateModel : PageModel
    {

        private ItemService ItemService;
        [BindProperty]
        public Item Item { get; set; }
        private ItemService itemService;
        public ItemUpdateModel(ItemService item)
        {
            ItemService = item;
        }
        public IActionResult OnGet(int Id)
        {
            Item = itemService.itemSearch(Id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ItemService.UpdateItem(Item);
            return RedirectToPage("Index");
        }
    }
}
