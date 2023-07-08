using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_PartyTracker
{
    public partial class Form2 : Form
    {
        int numPlayers = 0; // counter for the total number of players
        int currPlayer = 0; // counter for the current player
        public Form2(int numPlayers)
        {
            this.numPlayers = numPlayers; // saves the number of players passed by Form 1
            InitializeComponent();
            label1.Text += " " + numPlayers; // displays the number of players on label 1
            PlayerInfo.Text = "Please type player #" + (currPlayer + 1) + "'s name below";
        }

    }
}
