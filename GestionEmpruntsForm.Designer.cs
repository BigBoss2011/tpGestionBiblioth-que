namespace tpGestionBibliothèque
{
    partial class GestionEmpruntsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_dateRetour = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateEmprunt = new System.Windows.Forms.DateTimePicker();
            this.cmb_IdAdhérent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CodeLivre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.bt_Modifier = new System.Windows.Forms.Button();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empruntsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_dateRetour);
            this.groupBox1.Controls.Add(this.dtp_dateEmprunt);
            this.groupBox1.Controls.Add(this.cmb_IdAdhérent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_CodeLivre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(32, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Emprunts";
            // 
            // dtp_dateRetour
            // 
            this.dtp_dateRetour.Location = new System.Drawing.Point(163, 194);
            this.dtp_dateRetour.MinDate = new System.DateTime(2020, 2, 25, 0, 0, 0, 0);
            this.dtp_dateRetour.Name = "dtp_dateRetour";
            this.dtp_dateRetour.Size = new System.Drawing.Size(167, 24);
            this.dtp_dateRetour.TabIndex = 12;
            // 
            // dtp_dateEmprunt
            // 
            this.dtp_dateEmprunt.Location = new System.Drawing.Point(163, 140);
            this.dtp_dateEmprunt.MinDate = new System.DateTime(2020, 2, 26, 0, 0, 0, 0);
            this.dtp_dateEmprunt.Name = "dtp_dateEmprunt";
            this.dtp_dateEmprunt.Size = new System.Drawing.Size(167, 24);
            this.dtp_dateEmprunt.TabIndex = 11;
            this.dtp_dateEmprunt.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // cmb_IdAdhérent
            // 
            this.cmb_IdAdhérent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdAdhérent.FormattingEnabled = true;
            this.cmb_IdAdhérent.Location = new System.Drawing.Point(163, 88);
            this.cmb_IdAdhérent.Name = "cmb_IdAdhérent";
            this.cmb_IdAdhérent.Size = new System.Drawing.Size(167, 26);
            this.cmb_IdAdhérent.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-2, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Adhérent";
            // 
            // cmb_CodeLivre
            // 
            this.cmb_CodeLivre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodeLivre.FormattingEnabled = true;
            this.cmb_CodeLivre.Location = new System.Drawing.Point(163, 34);
            this.cmb_CodeLivre.Name = "cmb_CodeLivre";
            this.cmb_CodeLivre.Size = new System.Drawing.Size(167, 26);
            this.cmb_CodeLivre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-2, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Retour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-2, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Emprunt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Livre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Annuler);
            this.groupBox2.Controls.Add(this.bt_Supprimer);
            this.groupBox2.Controls.Add(this.bt_Modifier);
            this.groupBox2.Controls.Add(this.bt_Ajouter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(436, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.ForeColor = System.Drawing.Color.Black;
            this.bt_Annuler.Location = new System.Drawing.Point(63, 186);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(126, 44);
            this.bt_Annuler.TabIndex = 3;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_Supprimer
            // 
            this.bt_Supprimer.ForeColor = System.Drawing.Color.Black;
            this.bt_Supprimer.Location = new System.Drawing.Point(63, 129);
            this.bt_Supprimer.Name = "bt_Supprimer";
            this.bt_Supprimer.Size = new System.Drawing.Size(126, 44);
            this.bt_Supprimer.TabIndex = 2;
            this.bt_Supprimer.Text = "Supprimer";
            this.bt_Supprimer.UseVisualStyleBackColor = true;
            // 
            // bt_Modifier
            // 
            this.bt_Modifier.ForeColor = System.Drawing.Color.Black;
            this.bt_Modifier.Location = new System.Drawing.Point(63, 78);
            this.bt_Modifier.Name = "bt_Modifier";
            this.bt_Modifier.Size = new System.Drawing.Size(126, 44);
            this.bt_Modifier.TabIndex = 1;
            this.bt_Modifier.Text = "Modifier";
            this.bt_Modifier.UseVisualStyleBackColor = true;
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.ForeColor = System.Drawing.Color.Black;
            this.bt_Ajouter.Location = new System.Drawing.Point(63, 24);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.Size = new System.Drawing.Size(126, 44);
            this.bt_Ajouter.TabIndex = 0;
            this.bt_Ajouter.Text = "Ajouter";
            this.bt_Ajouter.UseVisualStyleBackColor = true;
            this.bt_Ajouter.Click += new System.EventHandler(this.bt_Ajouter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Coral;
            this.groupBox3.Location = new System.Drawing.Point(32, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 169);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des Emprunts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.empruntsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(5, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 133);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // empruntsBindingSource
            // 
            this.empruntsBindingSource.DataSource = typeof(tpGestionBibliothèque.Emprunts);
            this.empruntsBindingSource.CurrentChanged += new System.EventHandler(this.empruntsBindingSource_CurrentChanged);
            // 
            // GestionEmpruntsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "GestionEmpruntsForm";
            this.Text = "Formulaire de Gestion des Emprunts";
            this.Load += new System.EventHandler(this.GestionEmpruntsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Button bt_Modifier;
        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_CodeLivre;
        private System.Windows.Forms.DateTimePicker dtp_dateRetour;
        private System.Windows.Forms.DateTimePicker dtp_dateEmprunt;
        private System.Windows.Forms.ComboBox cmb_IdAdhérent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource empruntsBindingSource;
    }
}