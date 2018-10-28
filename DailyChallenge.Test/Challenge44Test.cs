using DailyChallenge.Google;
using Xunit;
using Shouldly;

namespace DailyChallenge.Test
{
    public class Challenge44Test
    {
        [Theory]
        [InlineData(new int[] { 8, 4, 2, 1 }, new string[] { "(8, 4)", "(8, 2)", "(8, 1)", "(4, 2)", "(4, 1)", "(2, 1)" })]
        [InlineData(new int[] { 2, 4, 1, 3, 5 }, new string[]{ "(2, 1)", "(4, 1)", "(4, 3)" })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new string[] { "(5, 4)", "(5, 3)", "(5, 2)", "(5, 1)", "(4, 3)", "(4, 2)", "(4, 1)", "(3, 2)", "(3, 1)", "(2, 1)" })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new string[] {})]
        public void VerifyInversionPairs(int[] list, string[] expected)
        {
            var cut = new Challenge44();

            var pairs = cut.CountInversions(list);

            pairs.ToArray().ShouldBeSubsetOf(expected);
        }
    }
}
