﻿using Xunit;

namespace Messerli.ChangeCase.Test
{
    public class ToKebabCaseTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("name", "name")]
        [InlineData("snake", "snake")]
        [InlineData("multiple_words", "multiple-words")]
        [InlineData("this_is_a_long_snake_case_name", "this-is-a-long-snake-case-name")]
        [InlineData("HTML", "html")]
        [InlineData("THIS_IS_A_CONSTANT", "this-is-a-constant")]
        [InlineData("camelCase", "camel-case")]
        [InlineData("PascalCase", "pascal-case")]
        [InlineData("kebab-case", "kebab-case")]
        [InlineData("HTTPConnection", "http-connection")]
        [InlineData("htmlDocument", "html-document")]
        [InlineData("rmiSomething", "rmi-something")]
        [InlineData("RmiSomething", "rmi-something")]
        [InlineData("RMISomething", "rmi-something")]
        public void NamesAnyCasingConvertCorrectlyToKebabCase(string sourceName, string expected)
        {
            Assert.Equal(expected, sourceName.ToKebabCase());
        }
    }
}