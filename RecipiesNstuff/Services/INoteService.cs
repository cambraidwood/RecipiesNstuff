using RecipiesNstuff.Domain.Models;

namespace RecipiesNstuff.Services
{
    public interface INoteService
    {

        public List<Note> Notes { get; }

        public List<Note> PagedNotes(int page, int perPage);

        public int AddNote (Note note);

    }
}
