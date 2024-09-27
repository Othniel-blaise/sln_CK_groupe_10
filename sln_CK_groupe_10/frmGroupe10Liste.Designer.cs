namespace Interface
{
    partial class frmGroupe10Liste
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
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnConsulter = new Button();
            btnSupprimer = new Button();
            btnFermer = new Button();
            btnActualiser = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(984, 457);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CkGroupe10_Id";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CkGroupe10NomPrenom";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CkGroupe10Date";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "CkGroupeTaille";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CategorieId";
            columnHeader5.Width = 200;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(284, 579);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += button1_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(414, 579);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 31);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnConsulter
            // 
            btnConsulter.Location = new Point(561, 579);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(94, 29);
            btnConsulter.TabIndex = 3;
            btnConsulter.Text = "Consulter";
            btnConsulter.UseVisualStyleBackColor = true;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(690, 579);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 31);
            btnSupprimer.TabIndex = 4;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(843, 579);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(843, 39);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(123, 29);
            btnActualiser.TabIndex = 6;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 48);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 8;
            label1.Text = "Nom du groupe";
            // 
            // frmGroupe10Liste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1008, 620);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnActualiser);
            Controls.Add(btnFermer);
            Controls.Add(btnSupprimer);
            Controls.Add(btnConsulter);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(listView1);
            Name = "frmGroupe10Liste";
            Text = "frmGroupe10Liste";
            Load += frmGroupe10Liste_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnConsulter;
        private Button btnSupprimer;
        private Button btnFermer;
        private Button btnActualiser;
        private TextBox textBox1;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}