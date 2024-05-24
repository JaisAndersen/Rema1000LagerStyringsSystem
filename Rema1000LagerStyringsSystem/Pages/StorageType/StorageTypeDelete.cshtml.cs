using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rema1000LagerStyringsSystem
{
    public class StorageTypeDeleteModel : PageModel
    {
        [BindProperty]
        public StorageType storageType { get; set; }
        public IStorageType repo;
        public StorageTypeDeleteModel(IStorageType repository) 
        {
            repo = repository;
        }
        public IActionResult OnGet(int Id)
        {
            storageType = repo.GetStorageType(Id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            repo.RemoveStorageType(id);
            return RedirectToPage("StorageTypeRead");
        }
    }
}
