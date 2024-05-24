using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;


namespace Rema1000LagerStyringsSystem
{
    public class ItemCreateModel : PageModel
    {
        [BindProperty]
        public Item item { get; set; }
        public SelectList selectListStorageType { get; set; }
        private IItem repo;
        public ItemCreateModel(IItem repository) 
        { 
            repo = repository;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddItem(item);
            return RedirectToPage("ItemPrint");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}

