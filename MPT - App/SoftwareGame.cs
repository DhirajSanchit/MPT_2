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
        int score;
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

            vragenTotaal = 14;
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
                score++;
            }

            //Fout antwoord, hangman krijgt een lijntje
            if (buttonTag != goedAntwoord && HangmanStatus != Dead)
            {
 
                    HangmanStatus++;
                    HangmanImgBox.Image = HangmanStatusImages[HangmanStatus];
            }

            //Alle vragen gehad
            if(vraagNummer == vragenTotaal)
            {
  
                //Toon succes 
                percentage = (int)Math.Round((double)(score*100) / vragenTotaal);


                MessageBox.Show(
                    "Spel beëindigd" + Environment.NewLine +
                    "Je hebt " + score + " vragen goed beantwoord!" + Environment.NewLine +
                    "Je cijfer is " + percentage + "%" + Environment.NewLine +
                        "Druk op OK om opnieuw te spelen"
                );

                //Reset  
                score = 0;
                vraagNummer = 0;
                HangmanStatus = 0;
                HangmanImgBox.Image = HangmanStatusImages[HangmanStatus];
                button3.Visible = true;
                button4.Visible = true;
                stelVraag(vraagNummer);
                
            }

            if(HangmanStatus == Dead)
            {

                 MessageBox.Show(
                    "Game Over!" + Environment.NewLine +
                    "Je hebt " + score + " vragen goed beantwoord!" + Environment.NewLine +
                    "Je cijfer is " + percentage + "%" + Environment.NewLine +
                       "Druk op OK om opnieuw te spelen"
                    );
                    
                    //Reset 
                    score = 0;
                    vraagNummer = 0;
                    HangmanStatus = 0;
                    HangmanImgBox.Image = HangmanStatusImages[HangmanStatus];
                    button3.Visible = true;
                    button4.Visible = true;
                    stelVraag(vraagNummer);

                

            }



            vraagNummer++;
            stelVraag(vraagNummer);

        }

        private void stelVraag(int vraagnr)
        {
            switch (vraagnr)
            {
                case 1:
//                  QuestionImageBox.Image =Properties.Resources.software_engineer;
                    Vraaglbl.Text = "Welke van de volgende data types " +
                        "biedt de meeste precisie: float, decimal, double, int?"; 
                    button1.Text = "int";
                    button2.Text = "decimal";
                    button3.Text = "double";
                    button4.Text = "float";
                    goedAntwoord = 4;
                break;

                case 2:
//                  QuestionImageBox.Image =Properties.Resources.images__2_;
                    Vraaglbl.Text = "Welk van de volgende programmeertalen is het" +
                        " populairst: python, javascript, C++, C#?";
                    button1.Text = "C++";
                    button2.Text = "javascript";
                    button3.Text = "python";
                    button4.Text = "C#?";
                    goedAntwoord = 3;
                    break;

                case 3:
//                  QuestionImageBox.Image =Properties.Resources.SE_Female;
                    Vraaglbl.Text = "Welk van de volgende data types wordt voor " +
                        "tekst gebruikt: char, string of long?";
                    button1.Text = "Char";
                    button2.Text = "string";
                    button3.Text = "Long";
                    button4.Text = "Alle 3";
                    goedAntwoord = 2;
                    break;

                case 4:
//                  QuestionImageBox.Image =Properties.Resources.software_engineer;
                    Vraaglbl.Text = "Wat is de definitie van een parameter? "; 
                    button1.Text = "Een variabele voor informatie die mee wordt gegeven bij " +
                        "functions etc.";
                    button2.Text = "Een variabele die je exclusief gebruikt bij testen";
                    button3.Text = "Een variabele die je gebruikt om berekeningen uit te voeren";
                    button4.Text = "een parameter is geen variabele";
                    goedAntwoord = 1;
                    break;

                //SE vragen
                case 5:
                    Vraaglbl.Text = "Waar houd je je als software engineer vooral mee bezig?";
                    button1.Text = "Vooral code schrijven";
                    button2.Text = "Vooral software testen";
                    button3.Text = "Vooral ontwerpen hoe de software gaat werken";
                    button4.Text = "All of the above";
                    goedAntwoord = 4;
                    break;

                case 6:
                    Vraaglbl.Text = "Is er een verschil tussen Software developper en engineer?";
                    button1.Text = "Nee, ze doen hetzelfde";
                    button2.Text = "Ja?";
                    button3.Text = "Nee, Het zijn synoniemen";
                    button4.Text = "Ja, een engineer houdt zich met meer bezig";
                    goedAntwoord = 2;
                    break;

                case 7:
                    button3.Visible = false;
                    button4.Visible = false;
                    Vraaglbl.Text = "Process, requirements, and team-management zijn" +
                        "dingen waar Business IT zich mee bezig houdt, Software niet.";
                    button1.Text = "Juist";
                    button2.Text = " Onjuist"; 
                    goedAntwoord = 2;
                    break;

                case 8:
                    button3.Visible = true;
                    button4.Visible = true; 
                    Vraaglbl.Text = "Bij Software wordt er meer gekeken naar:";
                    button1.Text = "Programming skills: Hoe goed kan je programmeren?";
                    button2.Text = "Soft skills: Een open-mind en will om te leren";
                    button3.Text = "Test skills: Hoe zorg jij ervoor dat de kwaliteit maximaal is?";
                    button4.Text = "Alle 3";
                    goedAntwoord = 2;
                    break;

                case 9:
//                  QuestionImageBox.Image =Properties.Resources.images;
                    Vraaglbl.Text = "Wat is de definitie van een 'bool'?"; 
                    button1.Text = "een afkorting van het wordt boolean";
                    button2.Text = "Wat developpers tegen elkaar roepen als iemand onzin praat";
                    button3.Text = "Een variabele die niet veranderbaar is";
                    button4.Text = " Een data type met maar twee " +
                        "mogelijke waarden; true en false";
                    goedAntwoord = 4;
                    break;
                
                //Strikvraag
                case 10:
                    Vraaglbl.Text = "Welke is juist?" +
                        "A: Long wordt gebruikt voor een lang stuk tekst." +
                        "of" +
                        "B: Een float biedt maar 2 decimalen precisie. ";
                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Visible = false;
                    button4.Visible = false;
                    goedAntwoord = 4;
                    break;

                case 11:
                    Vraaglbl.Text = "Welke is juist?" +
                        "A: Een list kan oneindig veel data bevatten" +
                        "of" +
                        "B: Char data type kan maar 4 karakters bevatten";
                    button1.Text = "A";
                    button2.Text = "B";
                    button3.Visible = false;
                    button4.Visible = false;
                    goedAntwoord = 1;
                    break;

                case 12:
                    button3.Visible = true;
                    button4.Visible = true;

                    Vraaglbl.Text = "Wie is de uitvinder van de programmeertaal " +
                        "'Java'?";
                    button1.Text = "Guido van Rossum";
                    button2.Text = " James Gosling";
                    button3.Text = "Rasmus Lerdorf";
                    button4.Text= "Anders Hejlsberg";
                    goedAntwoord = 2;
                    break;

                case 13:
                    Vraaglbl.Text = "In welk jaar is de programmeertaal 'C' ";
                    button1.Text = "1992";
                    button2.Text = "1982";
                    button3.Text = "1972";
                    button4.Text = "1962";
                    goedAntwoord = 3;
                    break;

                case 14:
                    Vraaglbl.Text = "Uit hoeveel Megabyte bestaat één Gigabit?";
                    button1.Text = "124 megabytes";
                    button2.Text = "1000 megabytes";
                    button3.Text = "1024 megabtyes";
                    button4.Text = "125 megabytes";
                    goedAntwoord = 4;
                    break;
            }
        } 

    }
}
