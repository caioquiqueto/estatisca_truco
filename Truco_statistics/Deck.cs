using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

    public class Deck
    {
        private List<card> cards = new List<card>();
        private string[] suits = { "Zap", "Copas", "Espadilha", "Picafumo" };
        private string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "Q", "J", "K" };

        public void buildDeck()
        {
            //cards = new card[40];
            //int index = 0;

            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 10; rank++)
                {
                    //cards[index] = new card(ranks[rank], suits[suit]);
                    cards.Add(new card(ranks[rank], suits[suit]));
                }
            }
        }

        public card getCard(int index)
        {
            int teste = 0;
            //return cards.ElementAt(index);
            return cards.ElementAt(index);
    }

        public void ShuffleDeck()
        {
            /*card[] newCards;
            newCards = new card[40];*/
            List<card> newCards = new List<card>();
            int tmpIndex = 0;
            Random myRandom = new Random();


            for (int nX = 39; nX >= 0; nX--)
            {
                tmpIndex = myRandom.Next(nX);
                newCards.Add(cards.ElementAt(tmpIndex));
                cards.RemoveAt(tmpIndex);
            }

            cards = newCards.ToList();
            tmpIndex = 0;
        }

    }

    public class card
    {
        private string rank;
        private string suit;
        private bool Manilha;
        private int Player;

        public card(string ranknew, string suitnew)
        {
            rank = ranknew;
            suit = suitnew;
            Manilha = false;
            Player = 0;
        }

        public card()
        {
            rank = "";
            suit = "";
            Manilha = false;
            Player = 0;
        }

    public string GetSuit()
    {
        return suit;
    }

    public string GetRank()
    {
        return rank;
    }
}


