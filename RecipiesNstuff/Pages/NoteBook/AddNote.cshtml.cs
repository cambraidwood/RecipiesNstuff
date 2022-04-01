using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipiesNstuff.Domain.Models;

namespace RecipiesNstuff.Pages.NoteBook
{
    public class AddNoteModel : PageModel
    {

        [BindProperty]
        public Note? Note { get; set; }

        [BindProperty]
        public string? Title { get; set; }   

        public void OnGet()
        {
        }

        public IActionResult OnGetAddNew()
        {
            return Page();
        }

        public IActionResult OnPostAddNewNote()
        {
            return Page();
        }
    }
}
