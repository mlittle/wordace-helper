using System;
using System.Collections.Generic;

namespace WordAceHelper
{
  public static class StringCombinations
  {
    //http://stackoverflow.com/questions/4472036/another-permutation-word-conundrum-with-linq
    public static IEnumerable<string> Combinations(this String characters)
    {
      //Return all combinations of 1, 2, 3, etc length
      for (var i = 1; i <= characters.Length; i++)
      {
        foreach (var s in CombinationsImpl(characters, i))
        {
          yield return s;
        }
      }
    }

    //http://stackoverflow.com/questions/4472036/another-permutation-word-conundrum-with-linq
    //Return all combinations (n choose k, not permutations) for a given length
    private static IEnumerable<string> CombinationsImpl(String characters, int length)
    {
      for (var i = 0; i < characters.Length; i++)
      {
        if (length == 1)
        {
          yield return characters.Substring(i, 1);
        }
        else
        {
          foreach (var next in CombinationsImpl(characters.Substring(i + 1, characters.Length - (i + 1)), length - 1))
            yield return characters[i] + next;
        }
      }
    }
  }
}
