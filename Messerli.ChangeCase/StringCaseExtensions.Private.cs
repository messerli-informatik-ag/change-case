﻿using Funcky;
using Funcky.Extensions;
using Funcky.Monads;

namespace Messerli.ChangeCase
{
    public static partial class StringCaseExtensions
    {
        private const int EmptySeparatorLength = 0;
        private const int SingleCharacterSeparatorLength = 1;
        private const int TailStart = 1;
        private const int CharacterNotFound = -1;
        private static readonly char[] NameSeparators = { '-', '_', '.' };

        private delegate Option<SplitResult> ExtractElement(string identifier, int startIndex);

        private static string FormatIdentifier(this string identifier, Func<string, string> partFormatter, string separator) =>
            identifier
                .SplitBy(SelectSplitStrategy(identifier))
                .Select(partFormatter)
                .JoinStrings(separator);

        private static ExtractElement SelectSplitStrategy(string identifier)
            => identifier.IndexOfAny(NameSeparators) == CharacterNotFound
                ? SplitOnCasing
                : SplitOnSeparators;

        private static Option<SplitResult> SplitOnCasing(string identifier, int startIndex)
            => startIndex >= identifier.Length
                ? Option<SplitResult>.None
                : ExtractByCasing(identifier, startIndex);

        private static Option<SplitResult> ExtractByCasing(string identifier, int startIndex)
            => identifier switch
            {
                _ when NextIsAbbreviation(identifier, startIndex) => ExtractUntil(identifier, startIndex, c => char.IsLower(c.Value)),
                _ when NextIsNumber(identifier, startIndex) => ExtractUntil(identifier, startIndex, c => !char.IsDigit(c.Value)),
                _ => ExtractNextWord(identifier, startIndex),
            };

        private static Option<SplitResult> ExtractUntil(string identifier, int startIndex, Func<ValueWithIndex<char>, bool> isEndPredicate)
            => identifier
                .WithIndex()
                .Skip(startIndex)
                .FirstOrNone(isEndPredicate)
                .AndThen(GetIndex)
                .Match(
                    none: ExtractLastElement(identifier, startIndex),
                    some: index => ExtractNextElement(identifier, startIndex, EmptySeparatorLength)(index - 1));

        private static bool NextIsNumber(string identifier, int startIndex)
            => identifier
                .Skip(startIndex)
                .TakeWhile(char.IsDigit)
                .Count() > 1;

        private static SplitResult ExtractNextWord(string identifier, int startIndex)
            => identifier
                .WithIndex()
                .Skip(startIndex + 1)
                .FirstOrNone(IsSeparatorCase)
                .AndThen(GetIndex)
                .Match(
                    none: ExtractLastElement(identifier, startIndex),
                    some: ExtractNextElement(identifier, startIndex, EmptySeparatorLength));

        private static bool IsSeparatorCase(ValueWithIndex<char> c)
            => char.IsUpper(c.Value) || char.IsDigit(c.Value);

        private static bool NextIsAbbreviation(string identifier, int startIndex)
            => identifier
                .Skip(startIndex)
                .TakeWhile(char.IsUpper)
                .Count() > 1;

        private static Option<SplitResult> SplitOnSeparators(string identifier, int startIndex)
            => startIndex > identifier.Length
                ? Option<SplitResult>.None
                : ExtractBySeparator(identifier, startIndex);

        private static SplitResult ExtractBySeparator(string identifier, int startIndex)
            => identifier
                .IndexOfAnyOrNone(NameSeparators, startIndex)
                .Match(
                    none: ExtractLastElement(identifier, startIndex),
                    some: ExtractNextElement(identifier, startIndex, SingleCharacterSeparatorLength));

        private static Func<int, SplitResult> ExtractNextElement(string text, int startIndex, int separatorLength)
            => index
                => new SplitResult(index + separatorLength, text.Substring(startIndex, index - startIndex));

        private static Func<SplitResult> ExtractLastElement(string text, int startIndex)
            => ()
                => new SplitResult(text.Length + 1, text.Substring(startIndex));

        private static Func<char, string> AppendNameTail(string name)
            => n
                => n + name.Substring(TailStart);

        private static string JoinStrings(this IEnumerable<string> strings, string separator)
            => string.Join(separator, strings);

        private static IEnumerable<string> SplitBy(this string text, ExtractElement extractNext)
            => Sequence
                .Successors(extractNext(text, 0), previous => extractNext(text, previous.NextStartIndex))
                .Select(r => r.Result);

        private static int GetIndex(ValueWithIndex<char> value)
            => value.Index;

        private static string ToLower(string value)
            => value.ToLower();

        private static string ToUpper(string value)
            => value.ToUpper();
    }
}
