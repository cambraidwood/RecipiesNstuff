namespace RecipiesNstuff.Domain.Models
{
    public class NoteItem
    {
        public int Id { get; }
        public string Text { get; }
        public string Image { get; }

        public bool IsLastItem { get; }

        public NoteItem()
        {
            this.Text = string.Empty;
            this.Image = string.Empty;
        }

        public NoteItem(int Id, string Text, string Image) : base()
        {
            this.Id = Id;
            this.Text = Text;
            this.Image = Image;
            this.IsLastItem = false;
        }
    }
}
