using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class ToCamelCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "name")]
        [InlineData("snake", "snake")]
        [InlineData("multiple_words", "multipleWords")]
        [InlineData("this_is_a_long_snake_case_name", "thisIsALongSnakeCaseName")]
        [InlineData("HTML", "html")]
        [InlineData("THIS_IS_A_CONSTANT", "thisIsAConstant")]
        [InlineData("camelCase", "camelCase")]
        [InlineData("PascalCase", "pascalCase")]
        [InlineData("kebab-case", "kebabCase")]
        [InlineData("HTTPConnection", "httpConnection")]
        [InlineData("htmlDocument", "htmlDocument")]
        [InlineData("rmiSomething", "rmiSomething")]
        [InlineData("RmiSomething", "rmiSomething")]
        [InlineData("RMISomething", "rmiSomething")]
        [InlineData("end_2_end", "end2End")]
        [InlineData("BUSINESS_2_BUSINESS", "business2Business")]
        [InlineData("End2End", "end2End")]
        [InlineData("business2Business", "business2Business")]
        public void NamesAnyCasingConvertCorrectlyToCamelCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.ToCamelCase());
        }
    }
}