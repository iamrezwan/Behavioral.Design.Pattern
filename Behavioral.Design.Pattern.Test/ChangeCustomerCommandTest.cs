using Behavioral.Design.Pattern.Entity;
using Xunit;

namespace Behavioral.Design.Pattern.Test
{
    public class ChangeCustomerCommandTest
    {
        [Fact]
        public void ShouldChangeBookName()
        {
            var book = new Book { Id = 1, Name = "A" };
            var cmd = new ChangeBookCommand(book);
            var newName = "xyz";
            cmd.Do(newName);
            Assert.Equal(newName, cmd.Book.Name);
        }
        [Fact]
        public void ShouldRevertChange()
        {
            var originalName = "xyz";
            var book = new Book { Id = 1, Name = originalName };
            var cmd = new ChangeBookCommand(book);
            var newName = "A";
            cmd.Do(newName);
            cmd.Undo();
            Assert.Equal(originalName, cmd.Book.Name);
        }
    }
}
