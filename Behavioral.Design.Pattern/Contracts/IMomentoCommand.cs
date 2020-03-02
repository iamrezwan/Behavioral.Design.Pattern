namespace Behavioral.Design.Pattern.Contracts
{
    public interface IMomentoCommand
    {
        void Do(string text);
        void Undo();
    }
}
