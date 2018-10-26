using DailyChallenge.Google;
using Shouldly;
using Xunit;

namespace DailyChallenge.test
{
    public class Challenge42Test
    {
        [Fact]
        public void ShouldReturnsSubSet()
        {
            // arrange
            var cut = new Challenge42();
            var list = new int[]{ 12, 1, 61, 5, 9, 2 };
            var target = 24;
            var n = new int[] {1, 2};
            // act
            var subset = cut.SpitSubset(list, target);

            // assert
            subset.ShouldBe(n);
        }
    }
}
