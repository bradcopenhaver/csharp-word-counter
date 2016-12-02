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
        while(words[i].Length > 0 && Char.IsPunctuation(words[i][0]))
        {
          words[i] = words[i].Remove(0, 1);
        }
        while(words[i].Length > 0 && Char.IsPunctuation(words[i][words[i].Length-1]))
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
    public string GetInputSearch()
    {
      return _inputSearch;
    }
    public string GetInputText()
    {
      return _inputText;
    }
    public int GetTotalMatches()
    {
      return _totalMatches;
    }
  }
}
