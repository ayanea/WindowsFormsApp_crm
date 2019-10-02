namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntQuit = new System.Windows.Forms.Button();
            this.bntAfficherJob = new System.Windows.Forms.Button();
            this.bntUpdJob = new System.Windows.Forms.Button();
            this.BntAddJob = new System.Windows.Forms.Button();
            this.labelDesac = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtB_JobName = new System.Windows.Forms.TextBox();
            this.txtB_Note = new System.Windows.Forms.TextBox();
            this.dtDesactivationJob = new System.Windows.Forms.DateTimePicker();
            this.BntDeleteJob = new System.Windows.Forms.Button();
            this.labelJob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntQuit
            // 
            this.bntQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntQuit.Location = new System.Drawing.Point(541, 6);
            this.bntQuit.Name = "bntQuit";
            this.bntQuit.Size = new System.Drawing.Size(75, 23);
            this.bntQuit.TabIndex = 2;
            this.bntQuit.Text = "Exit";
            this.bntQuit.Click += new System.EventHandler(this.bntQuit_Click_1);
            // 
            // bntAfficherJob
            // 
            this.bntAfficherJob.Location = new System.Drawing.Point(15, 6);
            this.bntAfficherJob.Name = "bntAfficherJob";
            this.bntAfficherJob.Size = new System.Drawing.Size(75, 23);
            this.bntAfficherJob.TabIndex = 3;
            this.bntAfficherJob.Text = "Afficher";
            this.bntAfficherJob.Click += new System.EventHandler(this.bntAfficherJob_Click);
            // 
            // bntUpdJob
            // 
            this.bntUpdJob.Location = new System.Drawing.Point(12, 355);
            this.bntUpdJob.Name = "bntUpdJob";
            this.bntUpdJob.Size = new System.Drawing.Size(75, 23);
            this.bntUpdJob.TabIndex = 4;
            this.bntUpdJob.Text = "Modifier";
            this.bntUpdJob.Click += new System.EventHandler(this.bntUpdJob_Click_1);
            // 
            // BntAddJob
            // 
            this.BntAddJob.Location = new System.Drawing.Point(93, 354);
            this.BntAddJob.Name = "BntAddJob";
            this.BntAddJob.Size = new System.Drawing.Size(75, 23);
            this.BntAddJob.TabIndex = 5;
            this.BntAddJob.Text = "Ajouter";
            this.BntAddJob.Click += new System.EventHandler(this.BntAddJob_Click);
            // 
            // labelDesac
            // 
            this.labelDesac.Location = new System.Drawing.Point(12, 299);
            this.labelDesac.Name = "labelDesac";
            this.labelDesac.Size = new System.Drawing.Size(100, 23);
            this.labelDesac.TabIndex = 7;
            this.labelDesac.Text = "Date Désactivation";
            // 
            // labelNote
            // 
            this.labelNote.Location = new System.Drawing.Point(12, 329);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(100, 23);
            this.labelNote.TabIndex = 8;
            this.labelNote.Text = "Note";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 227);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtB_JobName
            // 
            this.txtB_JobName.Location = new System.Drawing.Point(118, 268);
            this.txtB_JobName.Name = "txtB_JobName";
            this.txtB_JobName.Size = new System.Drawing.Size(100, 20);
            this.txtB_JobName.TabIndex = 10;
            // 
            // txtB_Note
            // 
            this.txtB_Note.Location = new System.Drawing.Point(118, 328);
            this.txtB_Note.Name = "txtB_Note";
            this.txtB_Note.Size = new System.Drawing.Size(100, 20);
            this.txtB_Note.TabIndex = 11;
            // 
            // dtDesactivationJob
            // 
            this.dtDesactivationJob.CustomFormat = "dd/MM/yyyy";
            this.dtDesactivationJob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDesactivationJob.Location = new System.Drawing.Point(118, 299);
            this.dtDesactivationJob.Name = "dtDesactivationJob";
            this.dtDesactivationJob.Size = new System.Drawing.Size(100, 20);
            this.dtDesactivationJob.TabIndex = 12;
            // 
            // BntDeleteJob
            // 
            this.BntDeleteJob.Location = new System.Drawing.Point(174, 354);
            this.BntDeleteJob.Name = "BntDeleteJob";
            this.BntDeleteJob.Size = new System.Drawing.Size(75, 23);
            this.BntDeleteJob.TabIndex = 13;
            this.BntDeleteJob.Text = "Supprimer";
            this.BntDeleteJob.UseVisualStyleBackColor = true;
            this.BntDeleteJob.Click += new System.EventHandler(this.BntDeleteJob_Click);
            // 
            // labelJob
            // 
            this.labelJob.Location = new System.Drawing.Point(12, 271);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(100, 23);
            this.labelJob.TabIndex = 14;
            this.labelJob.Text = "Job";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(616, 407);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.BntDeleteJob);
            this.Controls.Add(this.bntQuit);
            this.Controls.Add(this.bntAfficherJob);
            this.Controls.Add(this.bntUpdJob);
            this.Controls.Add(this.BntAddJob);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtB_JobName);
            this.Controls.Add(this.txtB_Note);
            this.Controls.Add(this.dtDesactivationJob);
            this.Controls.Add(this.labelDesac);
            this.Controls.Add(this.labelNote);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bntQuit;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Button bntAfficherJob;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntUpdJob;
        private System.Windows.Forms.TextBox txtB_JobName;
        private System.Windows.Forms.Label labelDesac;
        private System.Windows.Forms.DateTimePicker dtDesactivationJob;
        private System.Windows.Forms.Button BntAddJob;
        private System.Windows.Forms.TextBox txtB_Note;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button BntDeleteJob;
        private System.Windows.Forms.Label labelJob;
    }
}

