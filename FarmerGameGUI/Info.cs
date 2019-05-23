using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGameGUI
{
    class Info
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public void DisplayInfo(string assignment)
        {
            MessageBox.Show("\tName:\t\tBesian Kodra\t" +
            "\n\tCourse:\t\tITDEV-115\t\t" +
            "\n\tInstructor:\tMike Hunsicker\t\t" +
            "\n\tAssignment:\t" + assignment + "\t\t\t" +
            "\n\tDate:\t\t" + System.DateTime.Today.ToString("MM/dd/yyy") + "\t\t");
            synth.Speak("Welcome to Besian's farm simulator. This is a detailed and exact replication of what farmers do on a daily basis. Once you've figured out how to beat this game, you will then be ready to own and operate your own farm.");
        }
    }
}