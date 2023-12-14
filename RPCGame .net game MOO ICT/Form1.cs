using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPCGame.net_game_MOO_ICT
{
    public partial class Form1 : Form
    {

        string playerChoice;
        string computerChoice;
        string[] Options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, Options.Length);
            computerChoice = Options[i];

            lblPlayerChoice.Text = "Player is: " + UpdateTextandImage(playerChoice, PLAYER_PIC);
            lblCPUchoice.Text = "Computer is: " + UpdateTextandImage(computerChoice, CPU_PIC);
            CheckGame();
        }

        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.Rock_imgame_for_game;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.paper_images_for_game;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.Rpictures_for_game;
                    break;
            }

            return word;
        }

        private void CheckGame()
        {
            if(computerChoice == playerChoice)
            {
                draw = "Draw!";
            }
            else if (computerChoice == "R" && playerChoice == "S" || playerChoice == "R" && computerChoice == "P" || playerChoice == "P" && computerChoice == "S")
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;

            }

            lblCPUresult.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
            lblPlayerresult.Text = "Player Result: " + playerScore + Environment.NewLine + draw;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
