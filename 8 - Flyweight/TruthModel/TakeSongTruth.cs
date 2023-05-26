
namespace DesignPatterns._8___Flyweight.TruthModel
{
    public class TakeSongTruth
    {
        public static void Main(string[] args)
        {
            MusicNotes notes = new MusicNotes();

            new List<INote>
            {
                notes.ReturnNoteForName("do"),
                notes.ReturnNoteForName("re"),
                notes.ReturnNoteForName("mi"),
                notes.ReturnNoteForName("fa"),
            };

        }
    }
}
