using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_BlackJack
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Card dcard = new Card();
        Card pcard1 = new Card();
        Card pcard2 = new Card();

        //variables
        bool playerturn = true;
        int bet = 0;
        int winnings=0;
        public Form1()
        {
            InitializeComponent();
        }

        // Newgame starts the game by dealing the first two cards to the player and one card to the dealer.
        void NewGame()
        {
            //assign a card to dealer
            dcard.rank = rnd.Next(0, 13); //0 inclusive, 13 exclusive
            dcard.suit = rnd.Next(0, 4);
            dHand.Text = Convert.ToString(dcard.cardValue());
            pictureBox2.Image=dcard.CardImage();

            //assign two cards to player

            //card 1
            pcard1.rank = rnd.Next(0, 13);
            pcard1.suit = rnd.Next(0, 4);
            pictureBox1.Image = pcard1.CardImage();
            pHand.Text = Convert.ToString(pcard1.cardValue());

            //card 2
            pcard2.rank = rnd.Next(0, 13);
            pcard2.suit = rnd.Next(0, 4);
            pictureBox3.Image = pcard2.CardImage();
            pHand.Text = Convert.ToString(Convert.ToInt32(pHand.Text) + pcard2.cardValue());

            pictureBox4.Image = null;
            pictureBox5.Image = null;

            IsBlackJack();
        }

        // reset resets the game back to the starting point.
        void reset() 
        {
            bet = 0;
            textBox1.Text = Convert.ToString(bet);

            Twist_btn.Enabled = false;
            Stay_btn.Enabled = false;

        }

        // AddCard creates a new card and assigns a random rank and suit to it and adds to a hand
        void AddCard(Label hand, PictureBox pic)
        {
            Random rnd = new Random();
            Card card = new Card();

            card.rank = rnd.Next(0, 13);
            card.suit = rnd.Next(0, 4);
            pic.Image = card.CardImage();
            hand.Text = Convert.ToString(Convert.ToInt32(hand.Text) + card.cardValue());

        }

        // Busted is used to check if any hand >21
        bool Busted(Label hand)
        {
            if (Convert.ToInt32(hand.Text) > 21)
            {
                return true;
            }
            else
                return false;
        }

        // IsBlackJack checks if the player has an Ace and a card with rank 10
        void IsBlackJack() { 
            if ((pcard1.cardValue() + pcard2.cardValue() == 21))
                MessageBox.Show("BlackJack!! Player wins!");
           }

        // PlayAgain asks if the player wishes to play another round
        void PlayAgain()
        {
            DialogResult choice = MessageBox.Show("Would you like to play again? ", "Confirm", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
                reset();  //resets game but keeps the winnings 
            else
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        //twist button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pHand.Text) <= 21)
            {
                AddCard(pHand, pictureBox4);
                playerturn = false;
            }

            if (Busted(pHand))
            {
                MessageBox.Show("Busted! Dealer Wins");
                bet += Convert.ToInt32(Dbank.Text);
                Dbank.Text = Convert.ToString(bet);
                bet = 0;
                textBox1.Text = Convert.ToString(bet);

                PlayAgain();
            }

            if ((playerturn == false) && (Convert.ToInt32(dHand.Text) <= 17))
            {
                AddCard(dHand, pictureBox5);
                playerturn = true;
            }
            else if ((playerturn == false) && (Convert.ToInt32(dHand.Text) > 17))
            {
                playerturn = true;
            }

            if (Busted(dHand))
            {
                MessageBox.Show("Busted! Player Wins");
                winnings = bet * 2;
                label7.Text = Convert.ToString(winnings);
                textBox1.Text = " ";

                PlayAgain();
            }
        }

        //stay button
        private void Stay_btn_Click(object sender, EventArgs e)
        {
            playerturn = false;
            if ((playerturn == false) && (Convert.ToInt32(dHand.Text) <= 17))
            {
                AddCard(dHand, pictureBox5);
                playerturn = true;
            }
            else
            {
                if (Convert.ToInt32(pHand.Text) > (Convert.ToInt32(dHand.Text)))
                {
                    MessageBox.Show("Busted! Player wins!!");
                    winnings = bet * 2;
                    label7.Text = Convert.ToString(winnings);
                    
                    PlayAgain();
                }
                else if (Convert.ToInt32(pHand.Text) < (Convert.ToInt32(dHand.Text)))
                {
                    MessageBox.Show("Busted! Dealer Wins");
                    bet += Convert.ToInt32(Dbank.Text);
                    Dbank.Text = Convert.ToString(bet);
                    bet = 0;
                    textBox1.Text = Convert.ToString(bet);

                    PlayAgain();
                }
                else { 
                    MessageBox.Show("Draw!!");
                    PlayAgain();
                }
            }
            if (Busted(dHand))
            {
                MessageBox.Show("Busted! Player wins!!");
                winnings = bet * 2;
                label7.Text = Convert.ToString(winnings);
                
                PlayAgain();
            };
        }

        //Enter bet
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) 
            bet = Convert.ToInt32(textBox1.Text);
            
        }

        //Start the game
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bet >= 2 && bet <= 50)
            {
                //start a new game
                NewGame();
                Twist_btn.Enabled = true;
                Stay_btn.Enabled = true;

                if ((Convert.ToInt32(pHand.Text) == 9)|| (Convert.ToInt32(pHand.Text) == 10)|| (Convert.ToInt32(pHand.Text) == 11))
                {
                    DoubleDown_btn.Enabled = true;
                }
            }
            else
                MessageBox.Show("Please enter a starting value from 2 - 50");

        }

        //Double down function
        private void DoubleDown_btn_Click(object sender, EventArgs e)
        {
            bet += bet;
            textBox1.Text = Convert.ToString(bet);
            DoubleDown_btn.Enabled = false;

        }
    }
}
