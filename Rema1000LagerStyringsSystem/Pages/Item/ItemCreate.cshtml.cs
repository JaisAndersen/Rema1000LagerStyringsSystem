using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Rema1000LagerStyringsSystem.Models;
using Microsoft.AspNetCore.Http.Features;
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
            return RedirectToPage("GetAllItems");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}

