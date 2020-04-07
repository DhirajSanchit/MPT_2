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
    public partial class ProfielenForm : Form
    {
        public ProfielenForm()
        {
            InitializeComponent();
        }

        private string ProfielSelectie;




        private void SoftwareProfiel_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Name);
        }

        private void TechnologyProfiel_Click(object sender, EventArgs e)
        {

        }

        public void ButtonClickListener()
        {

        }

        private void Terug_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
