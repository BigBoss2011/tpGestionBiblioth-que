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
    public partial class GestionLivresForm : Form
    {
        public GestionLivresForm()
        {
            InitializeComponent();
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
            //To show the hidden Form (Form1 in our case)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Form1);
            if (formToShow != null)
                formToShow.Show();
        }

        private void GestionLivresForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Form1.OurBib.EnsembleLivres.lstLivres;
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Livre L = new Livre();
                L.Code = int.Parse(txt_code.Text);
                L.Titre = txt_Titre.Text;
                L.Auteur = txt_Auteur.Text;
                L.NbExemplaire = int.Parse(txt_NbreExamplaires.Text);
                bool res = Form1.OurBib.EnsembleLivres.Add(L);
                if (!res)
                    throw new Exception("Le Livre existe déjà\n  Verifier Code");
                MessageBox.Show("Livre ajouté avec succés...");
                 //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.EnsembleLivres.lstLivres;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
             try
            {
                //int RowIndex = dataGridView1.SelectedRows[0].Index;
                //ou bien
                int RowIndex = dataGridView1.CurrentRow.Index;
                int code = (int)dataGridView1[0, RowIndex].Value;
                if (RowIndex == -1)
                    throw new Exception("Vous devez selectionnez une ligne au niveau du dataGrid");
                txt_code.Text = code.ToString();
                Livre L = Form1.OurBib.EnsembleLivres.Find(code);
                if (L == null)
                    throw new Exception("Le Livre n'existe pas dans la bibliothèque");
                txt_Titre.Text = L.Titre;
                txt_Auteur.Text = L.Auteur;
                txt_NbreExamplaires.Text = L.NbExemplaire.ToString();
                //ou bien à partir du dataGridView directement
                txt_Titre.Text = (string)dataGridView1[1, RowIndex].Value;
                txt_Auteur.Text = (string)dataGridView1[2, RowIndex].Value;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //int RowIndex = dataGridView1.SelectedRows[0].Index;
                //ou bien
                int RowIndex = dataGridView1.CurrentRow.Index;
                int code = (int)dataGridView1[0, RowIndex].Value;
                if (RowIndex == -1)
                    throw new Exception("Vous devez selectionnez une ligne au niveau du dataGrid");
                txt_code.Text = code.ToString();
                Livre L = Form1.OurBib.EnsembleLivres.Find(code);
                if (L == null)
                    throw new Exception("Le Livre n'existe pas dans la bibliothèque");
                txt_Titre.Text = L.Titre;
                txt_Auteur.Text = L.Auteur;
                txt_NbreExamplaires.Text = L.NbExemplaire.ToString();
                //ou bien à partir du dataGridView directement
                //txt_Titre.Text = (string)dataGridView1[1, RowIndex].Value;
                //txt_Auteur.Text = (string)dataGridView1[2, RowIndex].Value;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //int RowIndex = dataGridView1.SelectedRows[0].Index;
                    //ou bien
                    int RowIndex = dataGridView1.CurrentRow.Index;
                    int code = (int)dataGridView1[0, RowIndex].Value;
                    if (RowIndex == -1)
                        throw new Exception("Vous devez selectionnez une ligne au niveau du dataGrid");
                    txt_code.Text = code.ToString();
                    Livre L = Form1.OurBib.EnsembleLivres.Find(code);
                    if (L == null)
                        throw new Exception("Le Livre n'existe pas dans la bibliothèque");
                    txt_Titre.Text = L.Titre;
                    txt_Auteur.Text = L.Auteur;
                    txt_NbreExamplaires.Text = L.NbExemplaire.ToString();

                    //or get values directly from the dataGridView
                    //txt_Titre.Text = (string)dataGridView1[1, RowIndex].Value;
                    //txt_Auteur.Text = (string)dataGridView1[2, RowIndex].Value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void bt_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(txt_code.Text);
                bool res= Form1.OurBib.EnsembleLivres.Remove(code);
                if (!res)
                    throw new Exception("Le Livre n'existe pas");
                MessageBox.Show("Livre supprimé avec succés...");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.EnsembleLivres.lstLivres;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var x = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
            // NB do not use .Value as it will not be set (committed) yet

            if (x.Length == 0)
            {
                MessageBox.Show("You must enter a value");
                e.Cancel = true;
            }
        }
    }
}
