using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordAceHelper
{
  public partial class Main : Form
  {
    private readonly WordFinder _finder = new WordFinder();

    public Main()
    {
      InitializeComponent();
    }

    private void MainLoad(object sender, EventArgs e)
    {
      //do nothing
    }

    private void ClearClick(object sender, EventArgs e)
    {
      txtHoleCards.Clear();
      txtCommunityCards.Clear();
      rtfPossibleHands.Clear();
      rtfOpponentHands.Clear();
      txtHoleCards.Focus();
    }

    private void CalculateClick(object sender, EventArgs e)
    {
      CalculateHands();
    }

    private void InputKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        CalculateHands();
    }

    private void CalculateHands()
    {
      var holeCards = txtHoleCards.Text.ToLower().Trim();
      var communityCards = txtCommunityCards.Text.ToLower().Trim();

      CalculatePossibleHands(communityCards, holeCards);
      CalculateOpponentHands(communityCards, holeCards);
    }

    private void CalculatePossibleHands(string communityCards, string holeCards)
    {
      var output = _finder.Process(holeCards + communityCards);
      var result = new StringBuilder();

      foreach (var item in output.OrderByDescending(o => o, new CompareWords()))
      {
        result.AppendLine(item + " - " + WordAceValues.GetWordValue(item));
      }

      rtfPossibleHands.Text = result.ToString();
    }

    private void CalculateOpponentHands(string communityCards, string holeCards)
    {
      var possibleOutputs = new List<string>();
      var possibleResults = new StringBuilder();
      var deck = Utilities.GetWordAceDeck();

      //remove cards already in play from the deck
      foreach (var card in (holeCards + communityCards))
      {
        deck.Remove(card.ToString());
      }

      //get the remaining possible hole cards
      var possibleOpponentHoleCards = Utilities.GetPossibleHoleCards(deck.OrderBy(d => d).ToList());

      //search for all possible words based on every combination of the hole cards and the community cards
      foreach (var opponentHoleCards in possibleOpponentHoleCards)
      {
        possibleOutputs.AddRange(_finder.Process(opponentHoleCards + communityCards));
      }

      foreach (var res in possibleOutputs.Select(o => o).Distinct().OrderByDescending(o => o, new CompareWords()))
      {
        possibleResults.AppendLine(res + " - " + WordAceValues.GetWordValue(res));
      }

      rtfOpponentHands.Text = possibleResults.ToString();
    }
  }
}
