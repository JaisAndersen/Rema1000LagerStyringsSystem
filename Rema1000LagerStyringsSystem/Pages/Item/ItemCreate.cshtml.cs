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
        public SelectList ItemSelectList { get; set; }
        [BindProperty]
        public string SelectListMærke {  get; set; }
        public Item item { get; set; }
        private IItem repo;
        public ItemCreateModel(IItem repository) 
        { 
            repo = repository;
            ItemSelectList = new SelectList(repo.GetAllItems());
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
            var itemSelectList = new List<Item>
            {
                new Item { Id = 1, Name = "Arla mælk", Price = 17, Mærke = "Arla" },
                new Item { Id = 2, Name = "Rema1000 mælk", Price = 17, Mærke = "Rema1000" }
            };
            ItemSelectList = new SelectList(itemSelectList, nameof(item.Mærke))
            return Page();
        }
    }
}

