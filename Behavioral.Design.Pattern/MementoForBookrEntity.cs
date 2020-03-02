using Behavioral.Design.Pattern.Entity;

namespace Behavioral.Design.Pattern
{
    public class MementoForBookrEntity
    {
        private Book _book;
        public MementoForBookrEntity(Book book)
        {
            _book = book.Clone();
        }
        public Book GetBook()
        {
            return _book;
        }
    }
}
