using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truco_statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            Deck myDeck = new Deck();
            Card myCard = new Card();


            myDeck.BuildDeck();

            myCard = myDeck.GetCard(int.Parse(txtIndex.Text));


            lblRank.Text = myCard.GetRank();
            lblSuit.Text = myCard.GetSuit();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Deck myDeck = new Deck();
            Card myCard = new Card();

            myDeck.BuildDeck();

            myDeck.ShuffleDeck();

            myCard = myDeck.GetCard(int.Parse(txtIndex.Text));

            lblRank.Text = myCard.GetRank();
            lblSuit.Text = myCard.GetSuit();
        }
    }
}
