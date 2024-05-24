using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem
{
    public class StatisticItemReadModel : PageModel
    {
        private IItem repo;
        public StatisticItemReadModel(IItem repository)
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
