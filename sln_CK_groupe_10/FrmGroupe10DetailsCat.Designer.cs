namespace Interface
{
    partial class FrmGroupe10DetailsCat
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
            l = new Label();
            CategorieDesignation = new Label();
            txtCategorie = new TextBox();
            txtCategorieDesignation = new TextBox();
            btnModifier = new Button();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(182, 92);
            l.Name = "l";
            l.Size = new Size(87, 20);
            l.TabIndex = 0;
            l.Text = "CategorieId";
            // 
            // CategorieDesignation
            // 
            CategorieDesignation.AutoSize = true;
            CategorieDesignation.Location = new Point(182, 175);
            CategorieDesignation.Name = "CategorieDesignation";
            CategorieDesignation.Size = new Size(154, 20);
            CategorieDesignation.TabIndex = 1;
            CategorieDesignation.Text = "CategorieDesignation";
            // 
            // txtCategorie
            // 
            txtCategorie.Location = new Point(408, 85);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new Size(310, 27);
            txtCategorie.TabIndex = 2;
            // 
            // txtCategorieDesignation
            // 
            txtCategorieDesignation.Location = new Point(408, 175);
            txtCategorieDesignation.Name = "txtCategorieDesignation";
            txtCategorieDesignation.Size = new Size(310, 27);
            txtCategorieDesignation.TabIndex = 3;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(442, 389);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 41);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(637, 389);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(89, 41);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // FrmGroupe10DetailsCat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(930, 514);
            Controls.Add(btnFermer);
            Controls.Add(btnModifier);
            Controls.Add(txtCategorieDesignation);
            Controls.Add(txtCategorie);
            Controls.Add(CategorieDesignation);
            Controls.Add(l);
            Name = "FrmGroupe10DetailsCat";
            Text = "FrmGroupe10DetailsCat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l;
        private Label CategorieDesignation;
        private TextBox txtCategorie;
        private TextBox txtCategorieDesignation;
        private Button btnModifier;
        private Button btnFermer;
    }
}