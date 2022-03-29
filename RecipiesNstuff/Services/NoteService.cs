using RecipiesNstuff.Domain.Models;
using System.Security.Cryptography;

namespace RecipiesNstuff.Services
{
    public class NoteService
    {

        private List<Note> _notes;
        public List<Note> Notes { get { return _notes; } }

        public NoteService()
        {
            _notes = new List<Note>();
            this.PopulateNotes();
        }

        public List<Note> PagedNotes(int page = 1, int perPage = 10)
        {
            var res = _notes.Skip((page -1) * perPage).Take(perPage).ToList();

            return res; 
        }

        private void PopulateNotes()
        {
            _notes = new List<Note>();

            int noteId = 1;
            int noteItemId = 1;

            int noteNumber = this.GenerateRandomNumber(10, 30);

            for (int i = 0; i < noteNumber; i++)
            {

                int imageNumber = this.GenerateRandomNumber(1, 3);

                List<NoteItem> noteItems = new List<NoteItem>();

                int itemNumber = this.GenerateRandomNumber(1, 10);

                for (int x = 1; x < itemNumber; x++)
                {
                    int noteItemImageNumber = this.GenerateRandomNumber(1, 3);

                    noteItems.Add(new NoteItem(noteItemId++, $"Note Item {x} for note {noteId}", $"/images/itemImage{noteItemImageNumber}.jpg"));
                }

                _notes.Add(new Note(noteId, $"Note {noteId}", $"Description for note {noteId++}", $"/images/noteImage{imageNumber}.jpg", "recipe", "https://www.domain.com", noteItems));
            }

        }

        private int GenerateRandomNumber(int min, int max)
        {
            var random = RandomNumberGenerator.Create();
            var bytes = new byte[sizeof(int)]; // 4 bytes
            random.GetNonZeroBytes(bytes);
            var val = BitConverter.ToInt32(bytes);
            var result = ((val - min) % (max - min + 1) + (max - min + 1)) % (max - min + 1) + min;
            return (result);
        }

    }
}
