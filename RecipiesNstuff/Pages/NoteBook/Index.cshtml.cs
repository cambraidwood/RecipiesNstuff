using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipiesNstuff.Domain.Extentions;
using RecipiesNstuff.Domain.Models;
using RecipiesNstuff.Services;

namespace RecipiesNstuff.Pages.NoteBook
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; }

        public List<Note> Notes;
        public int TotalNotes = 0;
        public int PerPage = 10;
        private INoteService _noteService;

        public IndexModel(INoteService noteService)
        {
            _noteService = noteService;
            TotalNotes = _noteService.Notes.Count;   
            Notes = new List<Note>();
        }

        public void OnGet()
        {
            Notes = _noteService.PagedNotes(PageNum, this.PerPage);
        }

        public IActionResult OnPostSearch(string searchText)
        {
            string x = searchText;

            return Page();
        }

        public IActionResult OnPostPagination()
        {
            return Page();
        }

        public IActionResult OnPostAddNewNote()
        {
            return new RedirectToPageResult("AddNote");
        }

    }

}
