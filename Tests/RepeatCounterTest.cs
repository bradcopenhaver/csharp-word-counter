using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_NoMatch_true()
    {
      //Arrange
      int expectedResult = 0;
      RepeatCounter newCounter = new RepeatCounter("spoon", "fork");
      //Act
      int result = newCounter.CountRepeats();
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
