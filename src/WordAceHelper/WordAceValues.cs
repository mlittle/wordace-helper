using System.Collections.Generic;

namespace WordAceHelper
{
  //hand values based on based on http://www.selfawaregames.com/2009/08/21/word-ace-letter-distribution/
  public static class WordAceValues
  {
    private static readonly Dictionary<char,int> LetterValues = new Dictionary<char, int>();

    static WordAceValues()
    {
      LetterValues.Add('A', 1);
      LetterValues.Add('B', 4);
      LetterValues.Add('C', 2);
      LetterValues.Add('D', 2);
      LetterValues.Add('E', 1);
      LetterValues.Add('F', 4);
      LetterValues.Add('G', 4);
      LetterValues.Add('H', 2);
      LetterValues.Add('I', 1);
      LetterValues.Add('J', 8);
      LetterValues.Add('K', 6);
      LetterValues.Add('L', 1);
      LetterValues.Add('M', 2);
      LetterValues.Add('N', 1);
      LetterValues.Add('O', 1);
      LetterValues.Add('P', 2);
      LetterValues.Add('Q', 10);
      LetterValues.Add('R', 1);
      LetterValues.Add('S', 1);
      LetterValues.Add('T', 1);
      LetterValues.Add('U', 1);
      LetterValues.Add('V', 6);
      LetterValues.Add('W', 6);
      LetterValues.Add('X', 8);
      LetterValues.Add('Y', 4);
      LetterValues.Add('Z', 8);
    }

    public static int GetWordValue(string word)
    {
      var ret = 0;

      foreach(var letter in word.ToUpper())
      {
        int value;

        if (LetterValues.TryGetValue(letter, out value))
        {
          ret += value;
        }
      }

      //words that are 5-7 chars in length receive a bonus based on length
      switch (word.Length)
      {
        case 5:
          ret += 2;
          break;
        case 6:
          ret += 5;
          break;
        case 7:
          ret += 20;
          break;
      }

      return ret;
    }
  }
}
