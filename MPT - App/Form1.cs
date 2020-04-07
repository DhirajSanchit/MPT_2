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

        private void ProfielenButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Check profielen!");
        }
    }
}
