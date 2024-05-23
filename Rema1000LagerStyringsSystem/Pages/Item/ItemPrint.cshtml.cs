using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Models;
using Rema1000LagerStyringsSystem.Services;
using System.Collections.Generic;


namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemPrintModel : PageModel
    {
        private ItemService ItemService;
        public ItemPrintModel(ItemService item)
        {
            ItemService = item;
        }
        public List<Item> ItemList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        /*
        public IActionResult OnGet()
        {
            ItemList = ItemService.Allitems();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                ItemList = itemService.FilterPizza(FilterCriteria);
            }

            return Page();
        }*/
    }
}
