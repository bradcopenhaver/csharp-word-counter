
namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _inputSearch;
    private string _inputText;
    private int _totalMatches = 0;

    public RepeatCounter(string search, string text)
    {
      _inputSearch = search;
      _inputText = text;
    }

    public int CountRepeats()
    {
      return _totalMatches;
    }
  }
}
