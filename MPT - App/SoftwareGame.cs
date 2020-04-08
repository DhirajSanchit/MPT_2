using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPT___App
{
    public partial class SoftwareGame : Form
    {

        //Software Quiz variables
        int goedAntwoord;
        int vraagNummer=1;
        //int score
        int HangmanStatus;
        int percentage;
        int vragenTotaal;
        int Dead;

        //Bitmap Array gevuld met Hangman images
        public Bitmap[] HangmanStatusImages =
        {
            Properties.Resources.Hangman_0,
            Properties.Resources.Hangman_1,
            Properties.Resources.Hangman_2,
            Properties.Resources.Hangman_3,
            Properties.Resources.Hangman_4,
            Properties.Resources.Hangman_5,
            Properties.Resources.Hangman_6,
            Properties.Resources.Hangman_7,
            Properties.Resources.Hangman_8,
            Properties.Resources.Hangman_9,

        };

        

        public SoftwareGame()
        {
            InitializeComponent();



            stelVraag(vraagNummer);

            vragenTotaal = 5;
            Dead = (int)HangmanStatusImages.Count() -1;

        }




        //Check het antwoord
        private void checkAntwoordEvent(object sender, EventArgs e)
        {
            //Check welk object het event stuurt
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == goedAntwoord)
            {
               //Doe iets

            }

            //Fout antwoord, hangman krijgt een lijntj
            if (buttonTag != goedAntwoord && HangmanStatus != Dead)
            {
 
                    HangmanStatus++;
                    HangmanImgBox.Image = HangmanStatusImages[HangmanStatus];
            }

            //Alle vragen gehad
            if(vraagNummer == vragenTotaal){
  
                //Toon succes 
            }

 

            vraagNummer++;
            stelVraag(vraagNummer);

        }

        private void stelVraag(int vraagnr)
        {
            switch (vraagnr)
            {
                case 1:
                    QuestionImageBox.Image = Properties.Resources.software_engineer;
                    Vraaglbl.Text = "Vraag 1";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                break;

                case 2:
                    QuestionImageBox.Image = Properties.Resources.images__2_;
                    Vraaglbl.Text = "Vraag 2";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;

                case 3:
                    QuestionImageBox.Image = Properties.Resources.SE_Female;
                    Vraaglbl.Text = "Vraag 3";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;

                case 4:
                    QuestionImageBox.Image = Properties.Resources.software_engineer;
                    Vraaglbl.Text = "Vraag 4";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;

                case 5:
                    QuestionImageBox.Image = Properties.Resources.images;
                    Vraaglbl.Text = "Vraag 5";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;
            }
        }

 
    }
}
