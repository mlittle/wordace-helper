using System;
using System.Collections.Generic;
using System.Linq;

namespace WordAceHelper
{
  public static class Utilities
  {
    public static IEnumerable<string> GetPossibleHoleCards(List<string> letterSet)
    {
      var ret = new List<string>();

      foreach (var dl in letterSet)
      {
        var letterset2 = new List<string>(letterSet);
        letterset2.Remove(dl);

        ret.AddRange(letterset2.Select(dl2 => dl + dl2));
      }

      return ret.Select(Alphabetize).Distinct().ToList();
    }

    //http://www.dotnetperls.com/anagram
    public static string Alphabetize(string s)
    {
      // Convert to char array, then sort and return
      var a = s.ToCharArray();

      Array.Sort(a);

      return new string(a);
    }

    public static void AddMultiple<T>(this List<T> col, int howMany, IEnumerable<T> items)
    {
      var newItems = items.ToList();

      if (items != null && howMany > 0)
        for (var i = 0; i < howMany; i++)
        {
          col.AddRange(newItems);
        }
    }

    // Card distribution based on http://www.selfawaregames.com/2009/08/21/word-ace-letter-distribution/
    // Cards and quantity:
    // E = 10
    // A,I,O = 7
    // R,T,N,L,C = 5
    // U,D,P = 4
    // M,H,Y,S = 3
    // G,B,F,W,K,V = 2
    // X,Z,J,Q, (E), (S) = 1
    // Only generates a deck of 98 cards which is odd because the game publisher sells a real deck
    // that contains 100 cards
    public static List<string> GetWordAceDeck()
    {
      var ret = new List<string>();

      ret.AddMultiple(10, new[] { "e" });
      ret.AddMultiple(7, new[] { "a", "i", "o" });
      ret.AddMultiple(5, new[] { "r", "t", "n", "l", "c" });
      ret.AddMultiple(4, new[] { "u", "d", "p" });
      ret.AddMultiple(3, new[] { "m", "h", "y", "s" });
      ret.AddMultiple(2, new[] { "g", "b", "f", "w", "k", "v" });
      ret.AddMultiple(1, new[] { "x", "z", "j", "q", "e", "s" });

      return ret;
    }
  }
}
