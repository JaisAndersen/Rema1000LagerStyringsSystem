using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Models;
using Rema1000LagerStyringsSystem.Services;
using System.Collections.Generic;
using Rema1000LagerStyringsSystem.Interface;


namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemPrintModel : PageModel
    {
        private ItemService itemService;
        private IItem repo;
        public ItemPrintModel(ItemService item)
        {
            itemService = item;
        }
        public List<Item> itemList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        
        public IActionResult OnGet()
        {
            itemList = itemService.GetAllItems();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                itemList = itemService.FilterItems(FilterCriteria);
            }

            return Page();
        }
    }
}
}
