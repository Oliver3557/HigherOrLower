using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherOrLower
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Easy");

            comboBox1.Items.Add("Medium");

            comboBox1.Items.Add("Hard");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           gamePanel.Visible = false;
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
    }
}
