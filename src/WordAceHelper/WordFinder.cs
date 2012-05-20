using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordAceHelper
{
  public class WordFinder
  {
    private readonly Dictionary<string, List<string>> _dict = new Dictionary<string, List<string>>();

    public WordFinder()
    {
      SetupDictionary();
    }
    
    private void SetupDictionary()
    {
      string line;

      //http://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
      var file = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), @"wordlist.txt"));
      
      while ((line = file.ReadLine()) != null)
      {
        var word = line.ToLower().Trim();

        //word ace hands never have more than 7 chars; no need to store words larger than that
        if (word.Length <= 7)
        {
          List<string> existList;
          var abcWord = Utilities.Alphabetize(word);

          if (_dict.TryGetValue(abcWord, out existList))
          {
            existList.Add(word);
          }
          else
          {
            _dict.Add(abcWord, new List<string> {word});
          }
        }
      }

      file.Close();
    }

    public IEnumerable<string> Process(string input)
    {
      var ret = new List<string>();

      foreach (var c in input.Combinations().Select(Utilities.Alphabetize).Distinct())
      {
        List<string> entry;

        if (_dict.TryGetValue(c, out entry))
        {
          ret.AddRange(entry);
        }
      }

      return ret;
    }
  }
}
