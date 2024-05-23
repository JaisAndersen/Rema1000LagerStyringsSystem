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
        private IItem repo;
        [BindProperty]
        public Item Item { get; set; }
        public ItemDeleteModel(IItem repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int Id)
        {
            Item = repo.GetItem(Id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            repo.RemoveItem(id);
            return RedirectToPage("ItemPrint");
        }
    }
}

