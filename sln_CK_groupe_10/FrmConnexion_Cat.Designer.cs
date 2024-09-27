namespace Interface
{
    partial class FrmConnexion_Cat
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
            label3 = new Label();
            cbRôle = new ComboBox();
            txtMotDePasse = new TextBox();
            txtNom = new TextBox();
            btnOk = new Button();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 110);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 220);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 333);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Rôle";
            // 
            // cbRôle
            // 
            cbRôle.FormattingEnabled = true;
            cbRôle.Location = new Point(322, 325);
            cbRôle.Name = "cbRôle";
            cbRôle.Size = new Size(259, 28);
            cbRôle.TabIndex = 3;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(322, 213);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(259, 27);
            txtMotDePasse.TabIndex = 4;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(322, 107);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(259, 27);
            txtNom.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(322, 435);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 44);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(487, 435);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 44);
            btnFermer.TabIndex = 7;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // FrmConnexion_Cat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(857, 553);
            Controls.Add(btnFermer);
            Controls.Add(btnOk);
            Controls.Add(txtNom);
            Controls.Add(txtMotDePasse);
            Controls.Add(cbRôle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmConnexion_Cat";
            Text = "FrmConnexion_Cat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbRôle;
        private TextBox txtMotDePasse;
        private TextBox txtNom;
        private Button btnOk;
        private Button btnFermer;
    }
}