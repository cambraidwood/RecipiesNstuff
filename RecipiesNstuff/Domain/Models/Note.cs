namespace RecipiesNstuff.Domain.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Tags { get; set; }
        public string? Url { get; set; }
        public List<NoteItem>? NoteItems { get; set; }
        public DateTime Created { get; }
        public DateTime Updated { get; }

        public Note()
        {
            this.Id = 0;
            this.Title = String.Empty;
            this.Description = String.Empty;
            this.Image = String.Empty;
            this.Tags = String.Empty;
            this.Url = String.Empty;
            //this.NoteItems = new List<NoteItem>();
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

            this.Created = DateTime.Now;
            this.Updated = this.Created;
        }

        public bool IsLastNoteItem(NoteItem ni)
        {
            return (ni == this.NoteItems?.Last());
        }
    }
}
