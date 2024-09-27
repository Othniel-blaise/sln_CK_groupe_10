namespace Interface
{
    partial class frmGroupeDétails
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
            label1 = new Label();
            label2 = new Label();
            txtGroupe_Id = new TextBox();
            txtNomPrenom = new TextBox();
            txtCatDesignation = new TextBox();
            label3 = new Label();
            btnEnregistrer = new Button();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 73);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Groupe_Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 165);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom Prenom";
            // 
            // txtGroupe_Id
            // 
            txtGroupe_Id.Location = new Point(414, 73);
            txtGroupe_Id.Name = "txtGroupe_Id";
            txtGroupe_Id.Size = new Size(272, 27);
            txtGroupe_Id.TabIndex = 3;
            // 
            // txtNomPrenom
            // 
            txtNomPrenom.Location = new Point(414, 165);
            txtNomPrenom.Name = "txtNomPrenom";
            txtNomPrenom.Size = new Size(272, 27);
            txtNomPrenom.TabIndex = 4;
            // 
            // txtCatDesignation
            // 
            txtCatDesignation.Location = new Point(414, 258);
            txtCatDesignation.Name = "txtCatDesignation";
            txtCatDesignation.Size = new Size(272, 27);
            txtCatDesignation.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 248);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 6;
            label3.Text = "CatDesignation";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(342, 422);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(102, 39);
            btnEnregistrer.TabIndex = 7;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(592, 422);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(112, 39);
            btnFermer.TabIndex = 8;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // frmGroupeDétails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(959, 542);
            Controls.Add(btnFermer);
            Controls.Add(btnEnregistrer);
            Controls.Add(label3);
            Controls.Add(txtCatDesignation);
            Controls.Add(txtNomPrenom);
            Controls.Add(txtGroupe_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGroupeDétails";
            Text = "frmGroupeDétails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGroupe_Id;
        private TextBox txtNomPrenom;
        private TextBox txtCatDesignation;
        private Label label3;
        private Button btnEnregistrer;
        private Button btnFermer;
    }
}