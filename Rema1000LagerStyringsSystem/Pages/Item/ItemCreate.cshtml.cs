using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using Rema1000LagerStyringsSystem.Models;
using Microsoft.VisualBasic;
using Rema1000LagerStyringsSystem.Interface;

namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemCreateModel : PageModel
    {
        private IItem repo;
        [BindProperty]
        public Item item { get; set; }
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
            if (repo.GetAllItems().Count < item.Id)
            {
                repo.AddItem(item);
            }
            return RedirectToPage("ItemPrint");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}

