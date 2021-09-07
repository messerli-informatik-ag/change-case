using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class ToUpperSnakeCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "NAME")]
        [InlineData("snake", "SNAKE")]
        [InlineData("multiple_words", "MULTIPLE_WORDS")]
        [InlineData("this_is_a_long_snake_case_name", "THIS_IS_A_LONG_SNAKE_CASE_NAME")]
        [InlineData("HTML", "HTML")]
        [InlineData("THIS_IS_A_CONSTANT", "THIS_IS_A_CONSTANT")]
        [InlineData("camelCase", "CAMEL_CASE")]
        [InlineData("PascalCase", "PASCAL_CASE")]
        [InlineData("kebab-case", "KEBAB_CASE")]
        [InlineData("HTTPConnection", "HTTP_CONNECTION")]
        [InlineData("htmlDocument", "HTML_DOCUMENT")]
        [InlineData("rmiSomething", "RMI_SOMETHING")]
        [InlineData("RmiSomething", "RMI_SOMETHING")]
        [InlineData("RMISomething", "RMI_SOMETHING")]
        [InlineData("end_2_end", "END_2_END")]
        [InlineData("BUSINESS_2_BUSINESS", "BUSINESS_2_BUSINESS")]
        [InlineData("End2End", "END_2_END")]
        [InlineData("business2Business", "BUSINESS_2_BUSINESS")]
        [InlineData("e02", "E_02")]
        public void NamesAnyCasingConvertCorrectlyToConstantCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.ToUpperSnakeCase());
        }
    }
}