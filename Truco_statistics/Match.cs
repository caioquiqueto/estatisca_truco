using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truco_statistics
{
    class Match
    {
        private Player player1 = new Player();
        private Player player2 = new Player();
        private Player player3 = new Player();
        private Player player4 = new Player();

        private Table table = new Table();

        private int scoreUS = 0;
        private int scoreThey = 0;
        
        public void StarMatch()
        {

            /*while (scoreUS >= 12 | scoreThey >= 12)
            {

            }*/
        }
        
    }
    
    class Set
    { }

    class Game
    { }

    class Player
    {
        private List<Card> hand = new List<Card>();
        private string name = "";

        public void ReciveCardHand(Card cardInput)
        {
            hand.Add(cardInput);
        }

        public void SendCardHand(Card cardInput)
        {
            hand.Remove(cardInput);
        }

        public void SetName(string nameInput)
        {
            name = nameInput;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Table
    {
        private Sit sitSouth = new Sit();
        private Sit sitEast = new Sit();
        private Sit sitNorth = new Sit();
        private Sit sitWest = new Sit();

        private Deck deck = new Deck();

        public void SetTable(Player playerSouth, Player playerEast, Player playerNorth, Player playerWest)
        {
            sitSouth.SetPlayer(playerSouth);
            sitEast.SetPlayer(playerEast);
            sitNorth.SetPlayer(playerNorth);
            sitWest.SetPlayer(playerWest);

            deck.ShuffleDeck();

            sitSouth.SetDealer(true);
        }
    }

    class Sit
    {
        private Player player = new Player();
        private bool isDealer = false;

        public void SetPlayer(Player playerInput) {
            player = playerInput;
        }

        public void SetDealer(bool isDealerInput)
        {
            isDealer = isDealerInput;
        }
    }
}
