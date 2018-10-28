using DailyChallenge.Amazon;
using Xunit;
using Shouldly;
namespace DailyChallenge.Test
{
    public class Challenge43Test
    {

        [Fact]
        public void ShouldPushMethodIncreaseItemCount()
        {
            var cut = new Challenge43();

            cut.Push(1);
            cut.Push(2);
            cut.Push(3);

            cut.Count().ShouldBe(3);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 3, new int[] { 4, 5 }, 5)]
        [InlineData(new int[] { 20, 30, 45 }, 45, new int[] { 56, 76 }, 76)]
        public void ShouldPopReturnsTopmostElement(int[] initialList, int initialPopValue, int[] secondaryList, int secondaryValue)
        {
            var cut = new Challenge43();

            for (int i = 0; i < initialList.Length; i++)
            {
                cut.Push(initialList[i]);
            }

            var item1 = cut.Pop();

            item1.ShouldBe(initialPopValue);

            for (int j = 0; j < secondaryList.Length; j++)
            {
                cut.Push(secondaryList[j]);
            }

            var item2 = cut.Pop();

            item2.ShouldBe(secondaryValue);
        }

        [Theory]
        [InlineData(new int[] {1, 2, 3, 4}, 4)]
        [InlineData(new int[] {23, 56, 98, 102 }, 102)]
        public void ShouldMaxRetrunsMaximumValueInStack(int[] values, int expectedMaxValue )
        {
            var cut = new Challenge43();
            for (int i = 0; i < values.Length; i++)
            {
                cut.Push(values[i]);
            }

            var max = cut.Max();

            max.ShouldBe(expectedMaxValue);
        }
    }
}
