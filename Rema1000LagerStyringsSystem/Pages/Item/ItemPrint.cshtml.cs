using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;


namespace Rema1000LagerStyringsSystem
{
    public class ItemPrintModel : PageModel
    {
        private IItem repo;
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public ItemPrintModel(IItem repository)
        {
            repo = repository;
        }
        public List<Item> itemList { get; set; }

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
