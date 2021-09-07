using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class FirstCharacterToLowerCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "name")]
        [InlineData("SNAKE", "sNAKE")]
        [InlineData("Multiple-words", "multiple-words")]
        [InlineData("this_is_a_long_snake_case_name", "this_is_a_long_snake_case_name")]
        [InlineData("HTML", "hTML")]
        [InlineData("htmlDocument", "htmlDocument")]
        [InlineData("end_2_end", "end_2_end")]
        [InlineData("BUSINESS_2_BUSINESS", "bUSINESS_2_BUSINESS")]
        [InlineData("End2End", "end2End")]
        [InlineData("business2Business", "business2Business")]
        public void FirstCharacterOnlyGetsLowerCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.FirstCharacterToLowerCase());
        }
    }
}