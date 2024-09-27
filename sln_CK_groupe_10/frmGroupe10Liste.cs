using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmGroupe10Liste : Form
    {
        public frmGroupe10Liste()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {



        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmGroupeDétails frm = new frmGroupeDétails();
            frm.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void frmGroupe10Liste_Load(object sender, EventArgs e)
        {

        }
    }
}
