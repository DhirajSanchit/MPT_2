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
        int percentage;
        int vragenTotaal;


        public SoftwareGame()
        {
            InitializeComponent();



            stelVraag(vraagNummer);

            vragenTotaal = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        //Check het antwoord
        private void checkAntwoordEvent(object sender, EventArgs e)
        {
            //Check welk object het event stuurt
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == goedAntwoord)
            {
                vraagNummer++;
                stelVraag(vraagNummer);

            }
        }

        private void stelVraag(int vraagnr)
        {
            switch (vraagnr)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.software_engineer;
                    Vraaglbl.Text = "Vraag 1";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                break;

                case 2:
                    pictureBox1.Image = Properties.Resources.images__2_;
                    Vraaglbl.Text = "Vraag 2";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.SE_Female;
                    Vraaglbl.Text = "Vraag 3";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.software_engineer;
                    Vraaglbl.Text = "Vraag 4";
                    button1.Text = "antwoord1";
                    button2.Text = "antwoord2";
                    button3.Text = "antwoord3";
                    button4.Text = "antwoord4";
                    goedAntwoord = 1;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.images;
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
