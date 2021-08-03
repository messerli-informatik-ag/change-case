using Funcky.Monads;

namespace Messerli.ChangeCase
{
    public static partial class StringCaseExtensions
    {
        private readonly struct SplitResult
        {
            public readonly string Result;

            public readonly int NextStartIndex;

            public SplitResult(int nextStartIndex, Option<string> result = default)
                => (Result, NextStartIndex) = (FlattenResult(result), nextStartIndex);

            private static string FlattenResult(Option<string> result)
                => result
                    .Match(
                        none: string.Empty,
                        some: ToLower);
        }
    }
}
