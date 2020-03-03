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
    public partial class GestionAdhérentsForm : Form
    {
        public GestionAdhérentsForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        Adhérent _bindedObject = new Adhérent();//{ Nom = "Initialized value"};
        private void GestionAdhérentsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.OurBib.EnsembleAdhérents.lstAdhérents;
            cmb_empruntNumber.SelectedIndex = 0;

        }

        

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();

            // To show the hidden Form (Form1 in our case)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void Bt_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Adhérent ad = new Adhérent();
                int x = int.Parse(txt_Id.Text);
                if (x <= 0)
                    throw new Exception("erreur Id negatif");
                ad.Id = x;
                ad.Nom = txt_Name.Text;
                ad.DateNaiss = dtp_BirthDay.Value;
                ad.Sexe = Genre.Homme;
                if (rd_woman.Checked)
                    ad.Sexe = Genre.Femme;
                ad.NbreEmpruntsEnCours = int.Parse(cmb_empruntNumber.Text);
                bool res = Form1.OurBib.EnsembleAdhérents.Add(ad);
                if (!res)
                    throw new Exception("L'adhérent existe déjà\n  Verifier Id");
                MessageBox.Show("Adhérent ajouté avec succés...");

                


                //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.EnsembleAdhérents.lstAdhérents;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Modifier_Click(object sender, EventArgs e)
        {
            Adhérent ad=Form1.OurBib.EnsembleAdhérents.FindById(11);
            MessageBox.Show(ad.Nom);
        }
    }
}
