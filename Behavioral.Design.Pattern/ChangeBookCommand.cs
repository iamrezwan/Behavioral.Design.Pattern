using Behavioral.Design.Pattern.Contracts;
using Behavioral.Design.Pattern.Entity;
using System.Collections.Generic;

namespace Behavioral.Design.Pattern
{
    public class ChangeBookCommand : IMomentoCommand
    {
        public Book Book { get; private set; }
        private readonly List<MementoForBookrEntity> _mementos = new List<MementoForBookrEntity>();
        public ChangeBookCommand(Book customer)
        {
            Book = customer;
        }
        public void Do(string newName)
        {
            _mementos.Add(new MementoForBookrEntity(Book));
            Book.Name = newName;
        }
        public void Undo()
        {
            Book = (_mementos[_mementos.Count - 1].GetCustomer());
            _mementos.RemoveAt(_mementos.Count - 1);
        }
    }
}
