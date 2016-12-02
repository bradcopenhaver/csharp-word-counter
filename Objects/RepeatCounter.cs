using System;

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
      string[] words = _inputText.ToLower().Split(' ');
      for(int i = 0; i < words.Length; i++)
      {
        while(Char.IsPunctuation(words[i][0]))
        {
          words[i] = words[i].Remove(0, 1);
        }
        while(Char.IsPunctuation(words[i][words[i].Length-1]))
        {
          words[i] = words[i].Remove(words[i].Length-1, 1);
        }
        if(_inputSearch == words[i])
        {
          _totalMatches++;
        }
      }
      return _totalMatches;
    }
  }
}
