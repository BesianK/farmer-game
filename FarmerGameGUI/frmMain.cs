using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Speech;
using System.Speech.Synthesis;
using System.Media;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGameGUI
{
    public partial class FrmMain : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SoundPlayer song = new SoundPlayer();
        FarmerGame farmer;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayGame();
        }
        private void DisplayGame()
        {
            farmer = new FarmerGame();
            DisplayBanks();
            btnMove.Visible = true;
            btnReset.Visible = false;
        }
        private void BtnMove_Click(object sender, EventArgs e)
        {
            string moveItem = "";

            if (radBtnFox.Checked)
            {
                moveItem = "FOX";
                synth.Speak("We may never know why farmers always carry foxes wherever they go.");
            }
            else if (radBtnChicken.Checked)
            {
                moveItem = "CHICKEN";
                synth.Speak("Cock a doodle do!");
            }
            else if (radBtnGrain.Checked)
            {
                moveItem = "GRAIN";
                synth.Speak("Swimming across a river with a bag of grains must be hard.");
            }
            else if (radBtnNothing.Checked)
            {
                moveItem = "NOTHING";
                synth.Speak("The lazy farmer carries himself.");
            }

            ProcessChoice(moveItem);
            DisplayBanks();
            CheckGameStatus();
        }
        private void ProcessChoice(string moving)
        {
            if (moving == "")
            {
                MessageBox.Show("Select something to move.");
            }
            else if (farmer.NorthBank.Contains(moving) && farmer.Farmer == FarmerGame.Direction.North ||
                    farmer.SouthBank.Contains(moving) && farmer.Farmer == FarmerGame.Direction.South ||
                    moving == "NOTHING")
            {
                farmer.Move(moving);
            }
            else
            {
                MessageBox.Show("The " + moving + " is not on the same side as the FARMER!");
            }
        }
        private void CheckGameStatus()
        {
            string eaten = farmer.AnimalAteFood();
            bool gameOver = false;

            if (farmer.DetermineWin())
            {
                MessageBox.Show("Congratulations! You win!");
                synth.Speak("I am so impressed! Only the top 10% of the most elite farmers are able to operate a farm this smoothly. And you did it all without a tractor. Good work!");
                gameOver = true;
            }
            else if (eaten == "FoxAteChicken")
            {
                MessageBox.Show("The FOX ate the CHICKEN!");
                synth.Speak("Oh no! That chicken has been murdered by the brutal fox.");
                gameOver = true;
            }

            else if (eaten == "ChickenAteGrain")
            {
                MessageBox.Show("The CHICKEN ate the GRAIN!");
                synth.Speak("That's not good! The grain is dead! The chicken murdered it in cold blood.");
                gameOver = true;
            }
            if (gameOver)
            {
                btnMove.Visible = false;
                btnReset.Visible = true;
            }
        }
        private void DisplayBanks()
        {
            if (farmer.NorthBank.Contains("FOX"))
            {
                picFoxNorth.Visible = true;
                picFoxSouth.Visible = false;
            }
            else
            {
                picFoxNorth.Visible = false;
                picFoxSouth.Visible = true;
            }

            if (farmer.NorthBank.Contains("CHICKEN"))
            {
                picChickenNorthPic.Visible = true;
                picChickenSouth.Visible = false;
            }
            else
            {
                picChickenNorthPic.Visible = false;
                picChickenSouth.Visible = true;
            }

            if (farmer.NorthBank.Contains("GRAIN"))
            {
                picGrainNorth.Visible = true;
                picGrainSouth.Visible = false;
            }
            else
            {
                picGrainNorth.Visible = false;
                picGrainSouth.Visible = true;
            }

            if (farmer.Farmer == FarmerGame.Direction.North)
            {
                picFarmerNorth.Visible = true;
                picFarmerSouth.Visible = false;
            }
            else
            {
                picFarmerNorth.Visible = false;
                picFarmerSouth.Visible = true;
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DisplayGame();  
        }
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayGame();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Farmer, Fox, Chicken, Grain game! " +
            "A farmer must get his fox, chicken and grain safely across a river from North bank " +
            "to South bank. The farmer makes trips between the banks and can take at most ONE " +
            "item with him each time. Unfortunately, if the farmer leaves the chicken and grain " +
            "together as he travels to other side of the river, the chicken eats the grain. " +
            "Furthermore, if the farmer leaves the fox and chicken together as he travels to " +
            "other side of river, the fox eats the chicken. " +
            "You must help the farmer by deciding what he should take across the river on " +
            "each trip. You may also decide that the farmer should take NOTHING on a trip. " +
            "Once you help the farmer move all three items successfully to the south bank, " +
            "you win. However, if the chicken or grain gets eaten, you lose.");
            synth.Speak("It's not exactly rocket science.");
        }
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.DisplayInfo("3A");
        }

        private void NewGame(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            lblNorthBank.BringToFront();
            song.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\RoarDrums.wav";
            song.Play();
        }

        private void MenuInfo(object sender, EventArgs e)
        {
            Info info = new Info();
            info.DisplayInfo("3A");
        }

        private void MenuInstructions(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Farmer, Fox, Chicken, Grain game! " +
            "A farmer must get his fox, chicken and grain safely across a river from North bank " +
            "to South bank. The farmer makes trips between the banks and can take at most ONE " +
            "item with him each time. Unfortunately, if the farmer leaves the chicken and grain " +
            "together as he travels to other side of the river, the chicken eats the grain. " +
            "Furthermore, if the farmer leaves the fox and chicken together as he travels to " +
            "other side of river, the fox eats the chicken. " +
            "You must help the farmer by deciding what he should take across the river on " +
            "each trip. You may also decide that the farmer should take NOTHING on a trip. " +
            "Once you help the farmer move all three items successfully to the south bank, " +
            "you win. However, if the chicken or grain gets eaten, you lose.");
            synth.Speak("It's not exactly rocket science.");
        }
    }
}