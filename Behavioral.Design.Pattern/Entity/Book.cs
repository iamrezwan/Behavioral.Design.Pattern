namespace Behavioral.Design.Pattern.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book Clone()
        {
            return MemberwiseClone() as Book;
        }
    }
}
