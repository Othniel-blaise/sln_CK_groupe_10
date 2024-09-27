namespace sln_CK_groupe_10
{
    partial class frmConnexion
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
            txtlogin = new TextBox();
            txtpassword = new TextBox();
            cbrôle = new ComboBox();
            label3 = new Label();
            btnok = new Button();
            btnfermer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 74);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 154);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(251, 67);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(353, 27);
            txtlogin.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(251, 154);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(353, 27);
            txtpassword.TabIndex = 3;
            // 
            // cbrôle
            // 
            cbrôle.FormattingEnabled = true;
            cbrôle.Location = new Point(251, 225);
            cbrôle.Name = "cbrôle";
            cbrôle.Size = new Size(353, 28);
            cbrôle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 233);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "rôle";
            // 
            // btnok
            // 
            btnok.Location = new Point(229, 355);
            btnok.Name = "btnok";
            btnok.Size = new Size(94, 29);
            btnok.TabIndex = 6;
            btnok.Text = "Ok";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btnfermer
            // 
            btnfermer.Location = new Point(454, 355);
            btnfermer.Name = "btnfermer";
            btnfermer.Size = new Size(94, 29);
            btnfermer.TabIndex = 7;
            btnfermer.Text = "Fermer";
            btnfermer.UseVisualStyleBackColor = true;
            btnfermer.Click += btnfermer_Click;
            // 
            // frmConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(954, 548);
            Controls.Add(btnfermer);
            Controls.Add(btnok);
            Controls.Add(label3);
            Controls.Add(cbrôle);
            Controls.Add(txtpassword);
            Controls.Add(txtlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmConnexion";
            Text = "frmConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtlogin;
        private TextBox txtpassword;
        private ComboBox cbrôle;
        private Label label3;
        private Button btnok;
        private Button btnfermer;
    }
}