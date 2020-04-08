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
    public partial class GamesMenu : Form
    {

        private SoftwareGame SoftGame;

        public GamesMenu()
        {
            InitializeComponent();
        }

        private void TerugButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void SoftwareGameButton_Click(object sender, EventArgs e)
        {
            Start("SoftwareGame");
        }


        public void Start(string form)
        {
            switch (form)
            {
                //GamesMenu
                case "SoftwareGame":

                    //Form instance als deze er nog niet is
                    if (SoftGame == null)
                    {
                        //Instantieer form 
                        SoftGame = new SoftwareGame();

                        //Geef het event mee als het form sluit
                        SoftGame.FormClosed += SoftGame_FormClosed;
                    }

                    //Laat GamesMenu zien, met MPT als owner
                    SoftGame.Show(this);
                    Hide();
                    break;
                default:
                    //do nothing

                    break;

            }
        }

        void SoftGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form is gesloten, dus de variable moet weer naar null.
            SoftGame = null;
            Show();
        }

    }
}
