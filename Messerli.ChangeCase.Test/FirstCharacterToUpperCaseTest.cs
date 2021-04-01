using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class FirstCharacterToUpperCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "Name")]
        [InlineData("SNAKE", "SNAKE")]
        [InlineData("multiple-words", "Multiple-words")]
        [InlineData("this_is_a_long_snake_case_name", "This_is_a_long_snake_case_name")]
        [InlineData("HTML", "HTML")]
        [InlineData("htmlDocument", "HtmlDocument")]
        public void FirstCharacterOnlyGetsUpperCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.FirstCharacterToUpperCase());
        }
    }
}