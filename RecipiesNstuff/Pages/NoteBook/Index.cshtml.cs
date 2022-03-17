using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipiesNstuff.Pages.Notebook
{
    public class IndexModel : PageModel
    {

        public List<Note> Notes;

        public IndexModel()
        {
            PopulateNotes();
        }

        private void PopulateNotes()
        {
            Notes = new List<Note>();

            List<NoteItem> noteItems = new List<NoteItem>();
            noteItems.Add(new NoteItem(1, "First Item First Note", "/images/itemImage1.jpg"));
            noteItems.Add(new NoteItem(2, "Second Item First Note", "/images/itemImage2.jpg"));

            Notes.Add(new Note(1, "First Note", "First Description", "/images/image1.jpg", "recipe", "www.domain.com", noteItems));

            noteItems = new List<NoteItem>();
            noteItems.Add(new NoteItem(1, "First Item Second Note", "/images/itemImage1.jpg"));
            noteItems.Add(new NoteItem(2, "Second Item Second Note", "/images/itemImage2.jpg"));

            Notes.Add(new Note(2, "Second Note", "Second Description", "/images/image2.jpg", "recipe", "www.domain.com", noteItems));

            noteItems = new List<NoteItem>();
            noteItems.Add(new NoteItem(1, "First Item Third Note", "/images/itemImage1.jpg"));
            noteItems.Add(new NoteItem(2, "Second Item Third Note", "/images/itemImage2.jpg"));

            Notes.Add(new Note(3, "Third Note", "Third Description", "/images/image3.jpg", "recipe", "www.domain.com", noteItems));
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

    public class Note
    {
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }
        public string Image { get; }
        public string Tags { get; }
        public string Url { get; }
        public List<NoteItem> NoteItems { get; }

        public Note()
        {
            NoteItems = new List<NoteItem>();
        }

        public Note(int Id, string Title, string Description, string Image, string Tags, string Url, List<NoteItem> NoteItems) : base()
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.Tags = Tags;
            this.Url = Url;
            this.NoteItems = NoteItems;
        }
    }

    public class NoteItem
    {
        public int Id { get; }
        public string Text { get; }
        public string Image { get; }

        public NoteItem()
        {
        }

        public NoteItem(int Id, string Text, string Image) : base()
        {
            this.Id= Id;
            this.Text = Text;
            this.Image= Image;
        }
    }
}
