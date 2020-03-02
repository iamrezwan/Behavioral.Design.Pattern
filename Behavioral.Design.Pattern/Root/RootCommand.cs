using Behavioral.Design.Pattern.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Design.Pattern.Root
{
    public abstract class RootCommand : IRootCommand
    {
        protected readonly List<string> Entries = new List<string>();
        public StringBuilder StringBuilder { get; set; } = new StringBuilder();
        public abstract void Do(string text);
        public abstract void Undo(string text);
    }
}
