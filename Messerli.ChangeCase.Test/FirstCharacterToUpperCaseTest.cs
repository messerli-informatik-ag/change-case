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
        [InlineData("end_2_end", "End_2_end")]
        [InlineData("BUSINESS_2_BUSINESS", "BUSINESS_2_BUSINESS")]
        [InlineData("End2End", "End2End")]
        [InlineData("business2Business", "Business2Business")]
        public void FirstCharacterOnlyGetsUpperCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.FirstCharacterToUpperCase());
        }
    }
}