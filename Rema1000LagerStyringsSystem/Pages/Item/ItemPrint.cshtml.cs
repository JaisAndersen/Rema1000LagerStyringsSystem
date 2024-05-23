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
        private IItem repo;
        public ItemPrintModel(IItem repository)
        {
            repo = repository;
        }
        public List<Item> itemList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        
        public IActionResult OnGet()
        {
            itemList = repo.GetAllItems();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                itemList = repo.FilterItems(FilterCriteria);
            }

            return Page();
        }
    }
}
