using Behavioral.Design.Pattern.Root;

namespace Behavioral.Design.Pattern
{
    public class AddTextCommand : RootCommand
    {
        public override void Do(string text)
        {
            StringBuilder.Append(text);
            Entries.Add(text);
        }
        public override void Undo(string text)
        {            
            var entrylength = Entries[Entries.Count - 1].Length;
            var totalLength = StringBuilder.Length;
            StringBuilder.Remove(totalLength - entrylength, entrylength);
            Entries.RemoveAt(Entries.Count - 1);
        }
    }
}
