using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rema1000LagerStyringsSystem.Services;
using Rema1000LagerStyringsSystem.Models;
using Microsoft.VisualBasic;
using Rema1000LagerStyringsSystem.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem.Pages.Itemcrud
{
    public class ItemCreateModel : PageModel
    {
        [BindProperty]
        public Item item { get; set; }
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

