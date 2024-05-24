using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rema1000LagerStyringsSystem
{
    public class StorageTypeUpdateModel : PageModel
    {
        [BindProperty]
        public StorageType storageType { get; set; }
        private IStorageType repo;

        public StorageTypeUpdateModel(IStorageType repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int Id)
        {
            storageType = repo.GetStorageType(Id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateStorageType(storageType);
            return RedirectToPage("StorageTypeRead");
        }
    }
}
