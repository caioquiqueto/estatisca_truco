using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Deck
{
    private List<Card> cards = new List<Card>();
    private string[] suits = { "Zap", "Copas", "Espadilha", "Picafumo" };
    private string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "Q", "J", "K" };

    public void BuildDeck()
    {
        //cards = new card[40];
        //int index = 0;

        for (int suit = 0; suit < 4; suit++)
        {
            for (int rank = 0; rank < 10; rank++)
            {
                //cards[index] = new card(ranks[rank], suits[suit]);
                cards.Add(new Card(ranks[rank], suits[suit]));
            }
        }
    }

    public Card GetCard(int index)
    {
        return cards.ElementAt(index);
}

    public void ShuffleDeck()
    {
        /*card[] newCards;
        newCards = new card[40];*/
        List<Card> newCards = new List<Card>();
        int tmpIndex = 0;
        Random myRandom = new Random();


        for (int nX = 39; nX >= 0; nX--)
        {
            tmpIndex = myRandom.Next(nX+1);
            newCards.Add(cards.ElementAt(tmpIndex));
            cards.RemoveAt(tmpIndex);
        }

        cards = newCards.ToList();
        tmpIndex = 0;
    }

}

public class Card
{
    private string rank;
    private string suit;
    private bool Manilha;

    public Card(string ranknew, string suitnew)
    {
        rank = ranknew;
        suit = suitnew;
        Manilha = false;
    }

    public Card()
    {
        rank = "";
        suit = "";
        Manilha = false;
    }

    public string GetSuit()
    {
        return suit;
    }

    public string GetRank()
    {
        return rank;
    }

    public void SetManilha(bool isManilhaInput)
    {
        Manilha = isManilhaInput;
    }

    public bool IsManilha()
    {
        return Manilha;
    }

}


