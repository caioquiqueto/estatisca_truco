using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truco_statistics
{
    public class Deck
    {
        private card[] cards;
        private string[] suits = { "Zap", "Copas", "Espadilha", "Picafumo" };
        private string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "Q", "J", "K" };

        public void buildDeck()
        {
            cards = new card[40];
            int index = 0;

            for (int suit = 1; suit <= 4; suit++)
            {
                for (int rank = 0; rank <= 10; rank++)
                {
                    cards[index] = new card(ranks[rank], suits[suit]);
                    index++;
                }
            }
        }

        public card getCard(int index)
        {
            return cards[index];
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
    }
}

