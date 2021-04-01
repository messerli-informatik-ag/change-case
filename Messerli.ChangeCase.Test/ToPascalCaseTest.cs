using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class ToPascalCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "Name")]
        [InlineData("snake", "Snake")]
        [InlineData("multiple_words", "MultipleWords")]
        [InlineData("this_is_a_long_snake_case_name", "ThisIsALongSnakeCaseName")]
        [InlineData("HTML", "Html")]
        [InlineData("THIS_IS_A_CONSTANT", "ThisIsAConstant")]
        [InlineData("camelCase", "CamelCase")]
        [InlineData("PascalCase", "PascalCase")]
        [InlineData("kebab-case", "KebabCase")]
        [InlineData("HTTPConnection", "HttpConnection")]
        [InlineData("rmiSomething", "RmiSomething")]
        [InlineData("RmiSomething", "RmiSomething")]
        [InlineData("RMISomething", "RmiSomething")]
        public void NamesAnyCasingConvertCorrectlyToPascalCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.ToPascalCase());
        }
    }
}
