using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rema1000LagerStyringsSystem
{
    //public class StorageTypeCreateModel : PageModel
    //{
    //    [BindProperty]
    //    public StorageType storageType {  get; set; }
    //    public IStorageType repo;
    //    public StorageTypeCreateModel(IStorageType repository) 
    //    {
    //        repo = repository;
    //    }
    //    public IActionResult OnPost()
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return Page();
    //        }
    //        if (repo.GetAllStorageTypes().Count < storageType.Id)
    //        {
    //            repo.AddStorageType(storageType);
    //        }
    //        return RedirectToPage("StorageTypeRead");
    //    }
    //    public IActionResult OnGet()
    //    {
    //        return Page();
    //    }
    //}
}
