using DailyChallenge.Google;
using Shouldly;
using Xunit;

namespace DailyChallenge.test
{
    public class Challenge42Test
    {
        [Theory]
        [InlineData(new int[] { 12, 1, 61, 5, 9, 2 }, 24,  new int[] { 12, 9, 2, 1} )]
        [InlineData(new int[] { 1, 4, 20, 3, 10, 5 }, 33, new int[] { 20, 10, 3 })]
        [InlineData(new int[] { 1, 4, 0, 0, 3, 10, 5 }, 7, new int[] { 4, 3, 0, 0 })]
        [InlineData(new int[] { 1, 4 }, 0, new int[] { })]
        public void ShouldReturnsSubSet(int[] row, int target, int[] expected )
        {
            // arrange
            var cut = new Challenge42();

            // act
            var subset = cut.SpitSubset(row, target);

            // assert
            subset.ShouldBe(expected);
        }
    }
}
