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
            {
                Result = result
                    .Match(
                        none: string.Empty,
                        some: r => r.ToLower());
                NextStartIndex = nextStartIndex;
            }
        }
    }
}
