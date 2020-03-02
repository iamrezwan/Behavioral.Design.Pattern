using System.Text;

namespace Behavioral.Design.Pattern.Contracts
{
    public interface IRootCommand
    {
        StringBuilder StringBuilder { get; set; }
        void Do(string text);
        void Undo(string text);
    }
}
