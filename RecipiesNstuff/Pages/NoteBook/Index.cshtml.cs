using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipiesNstuff.Domain.Extentions;
using RecipiesNstuff.Domain.Models;
using RecipiesNstuff.Services;

namespace RecipiesNstuff.Pages.Notebook
{
    public class IndexModel : PageModel
    {

        public List<Note> Notes;
        public int TotalNotes = 0;
        public int PerPage = 10;
        private NoteService noteService;

        public IndexModel()
        {
            noteService = new NoteService();
            TotalNotes = noteService.Notes.Count;   
            Notes = noteService.PagedNotes(1,this.PerPage);
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostSearch(string searchText)
        {
            string x = searchText;

            return Page();
        }

    }

}
