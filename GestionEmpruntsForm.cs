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
    public partial class GestionEmpruntsForm : Form
    {
        public GestionEmpruntsForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //To show the hidden Form (Form1 in our case)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Form1);
            if (formToShow !=null)
                formToShow.Show();
        }

        private void GestionEmpruntsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.OurBib.EnsembleEmprunts.lstEmprunts;
            cmb_CodeLivre.DataSource = Form1.OurBib.EnsembleLivres.LesCodes();
            cmb_IdAdhérent.DataSource = Form1.OurBib.EnsembleAdhérents.LesIds();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Emprunt Ep = new Emprunt();
                Ep.IdAdhérent = int.Parse(cmb_IdAdhérent.Text);
                Ep.CodeLivre = int.Parse(cmb_CodeLivre.Text);
                Ep.DateEmprunt = dtp_dateEmprunt.Value;
                Ep.DateRetour = dtp_dateRetour.Value;
                bool res = Form1.OurBib.EnsembleEmprunts.Add(Ep);
                if (!res)
                    throw new Exception("L'Emprunt existe déjà...");
                MessageBox.Show("Emprunt ajouté avec succés...");

                //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.EnsembleEmprunts.lstEmprunts;

                bool res1 = Form1.OurBib.EnsembleAdhérents.AddEmprunt(int.Parse(cmb_IdAdhérent.Text));
                if (!res1)
                    throw new Exception("L'adhérent n'existe pas..");
                bool res2 = Form1.OurBib.EnsembleLivres.AddEmprunt(int.Parse(cmb_CodeLivre.Text));
                if (!res2)
                    throw new Exception("Le livre n'existe pas..");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void empruntsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
