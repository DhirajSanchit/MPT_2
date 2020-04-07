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

        private ProfielenForm PF; 
        
        public MPT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 
        private void VerkenButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start verkenning!");
        }



        private void FaqButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("FAQ ME!");
        }


        //Info voor de 5 profielen
        private void ProfielenButton_Click(object sender, EventArgs e)
        {
            //Form instance als deze er nog niet is
            if (PF == null)
            {
                //Instantieer form 
                PF = new ProfielenForm();

                //Add eventhandler to cleanup after form closes
                PF.FormClosed += Pr_FormClosed;   
            }

            //Laat Profielenform zien, met MPT als owner
            PF.Show(this);  
            Hide();
        }

        void Pr_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form is gesloten, dus de variable moet weer naar null.
            PF = null;  
            Show();
        }

    }
}
