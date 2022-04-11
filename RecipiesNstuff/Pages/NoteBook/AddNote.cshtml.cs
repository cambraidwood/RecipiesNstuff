using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipiesNstuff.Domain.Models;
using RecipiesNstuff.Services;

namespace RecipiesNstuff.Pages.NoteBook
{
    public class AddNoteModel : PageModel
    {

        [BindProperty]
        public Note? Note { get; set; }

        [BindProperty]
        public string? Title { get; set; }

        private INoteService _noteService;

        public AddNoteModel(INoteService noteService)
        {
            _noteService = noteService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnGetAddNew()
        {
            return Page();
        }

        public IActionResult OnPostAddNewNote()
        {

            if (Note != null)
                _noteService.AddNote(Note);

            return new RedirectToPageResult("/Notebook/index", new { PageNum = (_noteService.Notes.Count() / 10) + (_noteService.Notes.Count() % 10 == 0 ? 0 : 1) });
        } 
    }
}
