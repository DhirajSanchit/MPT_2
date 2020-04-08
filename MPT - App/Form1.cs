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
    public partial class MPT : Form
    {
        //Todo: Gamesform namingconvention
        private GamesMenu  GamesMenu;
        private ProfielenForm PF;

        //ToDo: FAQform maken
        //private ;
        
        public MPT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //GamesMenu form
        private void VerkenButton_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("Start verkenning!");
            GoTo("GamesMenu");
        }

        //Info voor de 5 profielen
        private void ProfielenButton_Click(object sender, EventArgs e)
        {
            GoTo("Profielen");
        }



        //FAQ Form
        private void FaqButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("FAQ ME!");
        }


    

        void Pr_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form is gesloten, dus de variable moet weer naar null.
            PF = null;  
            Show();
        }

        void Games_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form is gesloten, dus de variable moet weer naar null.
            GamesMenu = null;
            Show();
        }


        public void GoTo(string form)
        {
            switch (form)
            {
                //GamesMenu
                case "GamesMenu": 

                    //Form instance als deze er nog niet is
                    if (GamesMenu == null)
                    {
                        //Instantieer form 
                        GamesMenu = new GamesMenu();

                        //Geef het event mee als het form sluit
                        GamesMenu.FormClosed += Games_FormClosed;
                    }

                    //Laat GamesMenu zien, met MPT als owner
                    GamesMenu.Show(this);
                    Hide();
                    break; 

                //Profielen
                case "Profielen":

                    //Form instance als deze er nog niet is
                    if (PF == null)
                    {
                        //Instantieer form 
                        PF = new ProfielenForm();

                        //Geef het event mee als het form sluit
                        PF.FormClosed += Pr_FormClosed;
                    }

                    //Laat Profielenform zien, met MPT als owner
                    PF.Show(this);
                    Hide(); 
                    break;

                //FAQ
                case "FAQ":

                break;

                default:
                    //do nothing

                    break;

            }
        }

    }
}
