using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class ToSnakeCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "name")]
        [InlineData("snake", "snake")]
        [InlineData("multiple_words", "multiple_words")]
        [InlineData("this_is_a_long_snake_case_name", "this_is_a_long_snake_case_name")]
        [InlineData("HTML", "html")]
        [InlineData("THIS_IS_A_CONSTANT", "this_is_a_constant")]
        [InlineData("camelCase", "camel_case")]
        [InlineData("PascalCase", "pascal_case")]
        [InlineData("kebab-case", "kebab_case")]
        [InlineData("HTTPConnection", "http_connection")]
        [InlineData("htmlDocument", "html_document")]
        [InlineData("rmiSomething", "rmi_something")]
        [InlineData("RmiSomething", "rmi_something")]
        [InlineData("RMISomething", "rmi_something")]
        public void NamesAnyCasingConvertCorrectlyToSnakeCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.ToSnakeCase());
        }
    }
}