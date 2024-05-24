using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using Rema1000LagerStyringsSystem.Models;
using Rema1000LagerStyringsSystem.Interface;
using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemUpdateModel : PageModel
    {
        [BindProperty]
        public Item Item { get; set; }
        private ItemService itemService;
        private IItem repo;
        public List<Item> itemList { get; set; }

        public ItemUpdateModel(ItemService item)
        {
            itemService = item;
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
            itemService.UpdateItem(Item);
            return RedirectToPage("Index");
        }
    }
}
