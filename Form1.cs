using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpGestionBibliothèque
{
    public partial class Form1 : Form
    {
        static internal Bibliothèque OurBib = new Bibliothèque();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_GestionLivres_Click(object sender, EventArgs e)
        {
            GestionLivresForm f1 = new GestionLivresForm();
            this.Hide();
            f1.Show();
        }

        private void bt_GestionAdhérents_Click(object sender, EventArgs e)
        {
            GestionAdhérentsForm f1 = new GestionAdhérentsForm();
            this.Hide();
            f1.Show();
        }

        private void bt_GestionEmprunts_Click(object sender, EventArgs e)
        {
            GestionEmpruntsForm f1 = new GestionEmpruntsForm();
            this.Hide();
            f1.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var response = MessageBox.Show(
                "Would you really close the window?",
        "Close Confirmation",
        MessageBoxButtons.YesNo, 
        MessageBoxIcon.Question);

            e.Cancel = (response == DialogResult.No);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
