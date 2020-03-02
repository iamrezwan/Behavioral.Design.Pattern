using Behavioral.Design.Pattern.Contracts;
using Xunit;

namespace Behavioral.Design.Pattern.Test
{
    public class AddTextCommandTest
    {
        [Fact]
        public void ShouldAddText()
        {          
            IRootCommand addTextCommand = new AddTextCommand();
            addTextCommand.Do("1234");
            Assert.Equal("1234", addTextCommand.StringBuilder.ToString());
        }
        [Fact]
        public void ShouldRemoveText()
        {
            IRootCommand addTextCommand = new AddTextCommand();
            addTextCommand.Do("1234");
            addTextCommand.Do("4321");
            addTextCommand.Undo("4321");
            Assert.Equal("1234", addTextCommand.StringBuilder.ToString());
        }
    }
}
