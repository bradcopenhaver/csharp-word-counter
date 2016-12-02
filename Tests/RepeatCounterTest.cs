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
    [Fact]
    public void CountRepeats_CompleteMatch_true()
    {
      //Arrange
      int expectedResult = 1;
      RepeatCounter newCounter = new RepeatCounter("spoon", "spoon");
      //Act
      int result = newCounter.CountRepeats();
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void CountRepeats_OneMatch_true()
    {
      //Arrange
      int expectedResult = 1;
      RepeatCounter newCounter = new RepeatCounter("spoon", "there is no spoon");
      //Act
      int result = newCounter.CountRepeats();
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
