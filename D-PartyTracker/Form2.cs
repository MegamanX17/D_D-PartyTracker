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
        bool containsInt = false; // boolean that checks for a string containing a number
        public Form2(int numPlayers)
        {
            this.numPlayers = numPlayers; // saves the number of players passed by Form 1
            InitializeComponent();
            label1.Text += " " + numPlayers; // displays the number of players on label 1
            PlayerInfo.Text = "Please type player #" + (currPlayer + 1) + "'s name " +
                "\nand max HP below (Ex: Roger, 25)";
        }

        private void EnterBttn_Click(object sender, EventArgs e)
        {
            
            // checks to see if the user wrote a number
            containsInt = (PlayerContent.Text).Any(char.IsDigit);

            // this if statement checks for a blank string entered by a user
            // and checks if there is a number being entered (error handling)
            if (PlayerContent.Text.Equals("") || (containsInt == false))
            {
                MessageBox.Show("Please enter an actual name with hp!", "D&D PartyTracker",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // this else-if statement saves a string entered by the user to the richtextbox
            // only if the names entered are not empty,
            // doesn't exceed the total number of players, and contains a number
            else if (currPlayer < numPlayers && !(PlayerContent.Text).Equals("") 
                && (containsInt == true))
            {
                PlayerList.Text += PlayerContent.Text + "\n"; // passes a name to the richtextbox list
                PlayerContent.Text = ""; // empties the textbox being used to write names
                currPlayer++; // increments current player being looked at
            }

            // this else-if statement prevents newer names from being entered if
            // all players have already received a name (error handling)
            else if(currPlayer == numPlayers)
            {
                MessageBox.Show("No more names can be entered!", "D&D PartyTracker",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (currPlayer < numPlayers)
            {
                PlayerInfo.Text = "Please type player #" + (currPlayer + 1) + "'s name " +
                "\nand max HP below (Ex: Roger, 25)"; // updates what is said on the form
            }

        }

        private void CloseBttn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // closes the entire program
        }
    }
}
