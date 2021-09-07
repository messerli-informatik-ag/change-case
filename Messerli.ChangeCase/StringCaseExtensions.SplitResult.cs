using Funcky.Monads;

namespace Messerli.ChangeCase
{
    public static partial class StringCaseExtensions
    {
        private readonly struct SplitResult
        {
            public readonly string Result;

            public readonly int NextStartIndex;

            public SplitResult(int nextStartIndex, string result)
                => (Result, NextStartIndex) = (result.ToLower(), nextStartIndex);
        }
    }
}
