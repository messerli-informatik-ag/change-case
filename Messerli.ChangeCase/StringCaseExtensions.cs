using Funcky.Extensions;

namespace Messerli.ChangeCase
{
    public static partial class StringCaseExtensions
    {
        public static string ToPascalCase(this string identifier)
            => identifier
                .FormatIdentifier(FirstCharacterToUpperCase, string.Empty);

        public static string ToCamelCase(this string identifier)
            => identifier
                .ToPascalCase()
                .FirstCharacterToLowerCase();

        public static string ToUpperSnakeCase(this string identifier)
            => identifier
                .FormatIdentifier(ToUpper, "_");

        public static string ToSnakeCase(this string identifier)
            => identifier
                .FormatIdentifier(ToLower, "_");

        public static string ToKebabCase(this string identifier)
            => identifier
                .FormatIdentifier(ToLower, "-");

        public static string FirstCharacterToUpperCase(this string name)
            => name.FirstOrNone()
                .AndThen(char.ToUpper)
                .Match(none: string.Empty, some: AppendNameTail(name));

        public static string FirstCharacterToLowerCase(this string name)
            => name.FirstOrNone()
                .AndThen(char.ToLower)
                .Match(none: string.Empty, some: AppendNameTail(name));
    }
}
