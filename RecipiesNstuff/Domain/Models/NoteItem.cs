namespace RecipiesNstuff.Domain.Models
{
    public class NoteItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        public bool IsLastItem { get; }

        public NoteItem()
        {
            this.Id = 0;
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
