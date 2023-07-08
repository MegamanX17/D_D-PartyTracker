using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_PartyTracker
{
    public partial class Form1 : Form
    {
        // private TextBox txt;
        // private Button lck;
        int numPlayers = 0; // counter for the current number of players
        // int numLabels = 1; // counter for current number of label objects
        // int numTextBox = 1; // counter for current number of text box objects
        // int numBttn = 1; // counter for current number of button objects
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // Closes the entire form window
            Application.Exit();
        }

        /**
         * This method controls the behavior of the "Enter" button and
         * calls the constructor of the next form.
         */
        private void EnterBttn_Click(object sender, EventArgs e)
        {
            // Stores the current number of players entered in the numericUpDown
            numPlayers = Convert.ToInt32(numericUpDown1.Value);

            Hide();
            Form f2 = new Form2(numPlayers);
            f2.ShowDialog();
            Close();



            /*
            // clears everything on the current windows form
            this.Controls.Clear();

            // this loop creates a new label and a new text box
            // based on the current number of players
            for (int i = 0; i < numPlayers; i++)
            {
                addButton(); // calls the add button method
                addLabel(); // calls the add label method
                addText(); // calls the add text method
            }
            addEnterButton(); // calls the add "Enter" button method
            //addClearButton(); // calls the add "Clear" button method
            */
        }



        //The sections of code beyond this point has been commented and will no longer be used.
        //The commented sections of coding will not be removed.














        /**
         * The addText method creates a new text box object and adds that object
         * to the currently active window form.
         */
        /*private System.Windows.Forms.TextBox addText()
        {
            // new text box object is constructed
            txt = new TextBox();


            // new text box object is added to the form
            this.Controls.Add(txt); 

            // changes what is said inside the text box
            //txt.Text = "TextBox #" + this.numTextBox.ToString();

            // spacing between the text box and the top of the window form
            txt.Top = numTextBox * 40;

            // spacing between the text box and the left side of the window form
            txt.Left = 195;

            // increases the total number of current text boxes made by 1
            numTextBox++;
            return txt;
        }*/

        /**
         * The addLabel method creates a new label object and adds that object
         * to the currently active window form.
         */
        /*private System.Windows.Forms.Label addLabel()
        {
            // new label object is constructed
            Label lab = new Label();

            // new size is set for the label object
            lab.Size = new Size(95, 15);

            // label object is added to the current window form
            this.Controls.Add(lab);

            // changes what is said on the label
            lab.Text = "Player #" 
                + this.numLabels.ToString() + "'s name:";

            // spacing between the label and the top side of the window form
            lab.Top = numLabels * 40;

            // spacing between the label and the left side of the window form
            lab.Left = 100;

            // increases the total number of current labels made by 1
            numLabels++;
            return lab;
        }*/


        /**
         * The addButton method creates a new button object and adds that object
         * to the currently active window form.
         */
        /*private System.Windows.Forms.Button addButton()
        {
            lck = new Button();

            lck.Click += Lock_Click;

            this.Controls.Add(lck);

            lck.Text = "Lock";

            lck.Top = numTextBox * 40;

            lck.Left = 300;

            return lck;
        }*/


        /*private System.Windows.Forms.Button addEnterButton()
        {
            // new button object is constructed
            Button btn = new Button();

            btn.Click += Button_Click;

            // new button object is added to the window form
            this.Controls.Add(btn);

            // changes what is said on the button
            btn.Text = "Enter";

            btn.Top = numTextBox * 42;

            btn.Left = 175;

            // increases the total number of current buttons made by 1
            //numBttn++;
            return btn;
        }*/


        /*
        private System.Windows.Forms.Button addClearButton()
        {
            Button btn = new Button();

            this.Controls.Add(btn);

            btn.Text = "Clear";

            btn.Top = numTextBox * 45;

            btn.Left = 225;

            return btn;
        }
        */


        /*private void Button_Click(object sender, EventArgs e)
        {
            // clears everything on the current windows form
            this.Controls.Clear();
        }*/


        /*private void Lock_Click(object sender, EventArgs e)
        {
            if (lck.Text == "Lock")
            {
                txt.ReadOnly = true;
                lck.Text = "Unlock";
            } 
            
            else
            {
                txt.ReadOnly = false;
                lck.Text = "Lock";
            }
        }*/
    }
}