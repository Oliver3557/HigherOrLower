using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherOrLower
{
    public partial class Form1 : Form
    {
        private int gameNumber;
        private int winsCount = 0;
        private int lossesCount = 0;
        private int guessCount = 0;
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Easy");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Hard");

            UpdateWinsLabel();
            UpdateLossesLabel();
            UpdateCountLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           gamePanel.Visible = false;
        }
        private void UpdateWinsLabel()
        {
            winsLabel.Text = $"Wins: {winsCount}";
        }
        private void UpdateLossesLabel()
        {
            lossesLabel.Text = $"Losses: {lossesCount}";
        }
        private void UpdateCountLabel()
        {
            countLabel.Text = $"Guesses: {guessCount}";
        }

        private void UpdateGame()
        {
            //Generate game number.
            Random rnd = new Random();

            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(comboBox1.SelectedItem.ToString())) 
            {
                gamePanel.Visible = false;
                MessageBox.Show("Please select a difficulty before proceeding.");
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Easy")
            {
                gameNumber = rnd.Next(1, 10);
                difficultyLabel.Text = "Difficulty: Easy";
            }
            else if (comboBox1.SelectedItem.ToString() == "Medium")
            {
                gameNumber = rnd.Next(1, 25);
                difficultyLabel.Text = "Difficulty: Medium";
            }
            else if (comboBox1.SelectedItem.ToString() == "Hard")
            {
                gameNumber = rnd.Next(1, 50);
                difficultyLabel.Text = "Difficulty: Hard";
            }

            

            guessCount = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //(Rules back button) Go back to main menu
            homePanel.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            //Go to rule page
            homePanel.Visible = false;
            helpPanel.Visible = true;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Go to Game Page
            gamePanel.Visible = true;

            UpdateGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Main Menu Exit Button
            Application.Exit();
        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Game Exit Button
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Game back button
            homePanel.Visible = true;
            gamePanel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Entered Number

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //1. Check if it is correct.
            //2. See if it is higher / lower.
            //3. Update higher or lower label.
            //4. Update Wins / Losses upon win or loss.
            string guessed = textBox1.Text;
            int guessedInt = int.Parse(guessed);

            guessCount++;

            if (guessedInt == gameNumber){
                //User Wins
                responseLabel.Text = "You Win!";
                winsCount++;

                UpdateGame();
            }
            else if(guessedInt > gameNumber){
                //gameNumber is lower
                responseLabel.Text = "Guess Lower!";

            }else if(guessedInt < gameNumber){
                //gameNumber is higher
                responseLabel.Text = "Guess Higher!";
            }
            
            if (guessCount == 5 && guessedInt != gameNumber)
            {
                //User Loses
                responseLabel.Text = "You Lose!";
                lossesCount++;

                UpdateGame();
            }

            
            UpdateWinsLabel();
            UpdateLossesLabel();
            UpdateCountLabel();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Difficulty Selection.
        }
    }
}
