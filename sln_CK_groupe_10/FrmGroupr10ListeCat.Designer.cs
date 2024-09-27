namespace Interface
{
    partial class FrmGroupr10ListeCat
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnActualiser = new Button();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnConsulter = new Button();
            btnSupprimer = new Button();
            btnFermer = new Button();
            txtNomdecatégorie = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.GridLines = true;
            listView1.Location = new Point(37, 89);
            listView1.Name = "listView1";
            listView1.Size = new Size(849, 378);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CategorieId";
            columnHeader1.Width = 420;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CatDesignation";
            columnHeader2.Width = 425;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(792, 31);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(94, 37);
            btnActualiser.TabIndex = 1;
            btnActualiser.Text = "Actualier";
            btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(250, 494);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 35);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(387, 494);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 35);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            btnConsulter.Location = new Point(524, 494);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(94, 35);
            btnConsulter.TabIndex = 4;
            btnConsulter.Text = "Consulter";
            btnConsulter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(659, 494);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(100, 35);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(792, 494);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 35);
            btnFermer.TabIndex = 6;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // txtNomdecatégorie
            // 
            txtNomdecatégorie.Location = new Point(524, 41);
            txtNomdecatégorie.Name = "txtNomdecatégorie";
            txtNomdecatégorie.Size = new Size(235, 27);
            txtNomdecatégorie.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 44);
            label1.Name = "label1";
            label1.Size = new Size(220, 20);
            label1.TabIndex = 8;
            label1.Text = "Nom de categorie commençant";
            // 
            // FrmGroupr10ListeCat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(912, 547);
            Controls.Add(label1);
            Controls.Add(txtNomdecatégorie);
            Controls.Add(btnFermer);
            Controls.Add(btnSupprimer);
            Controls.Add(btnConsulter);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnActualiser);
            Controls.Add(listView1);
            Name = "FrmGroupr10ListeCat";
            Text = "FrmGroupr10ListeCat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnActualiser;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnConsulter;
        private Button btnSupprimer;
        private Button btnFermer;
        private TextBox txtNomdecatégorie;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}