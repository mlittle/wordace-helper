using System.Collections.Generic;

namespace WordAceHelper
{
  //Compares strings based on their Word Ace Hand Value
  public class CompareWords : IComparer<string>
  {
    public int Compare(string x, string y)
    {
      var ret = -1;
      var xValue = WordAceValues.GetWordValue(x);
      var yValue = WordAceValues.GetWordValue(y);

      if (xValue > yValue)
        ret = 1;
      if (xValue == yValue)
        ret = 0;

      return ret;
    }
  }
}
