

using DesignPatterns._8___Flyweight.ErrorModel;

namespace DesignPatterns._8___Flyweight
{
    public class MusicNotes
    {
        private static IDictionary<string, INote> notes = new Dictionary<string, INote>()
        {
            {"do", new Do()},
            {"re", new Re()},
            { "mi", new Mi()},
            {"fá", new Fa()},
        };

   
        public INote ReturnNoteForName(string nameMusic)
        {
            return notes[nameMusic];
        }
    }
}
