namespace Interface
{
    partial class FrmMenuPrincipal_cat
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
            menuStrip1 = new MenuStrip();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            sauvegarderToolStripMenuItem = new ToolStripMenuItem();
            imprimerToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            categorieToolStripMenuItem = new ToolStripMenuItem();
            groupeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem, fichierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(894, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categorieToolStripMenuItem, groupeToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(73, 24);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sauvegarderToolStripMenuItem, imprimerToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            sauvegarderToolStripMenuItem.Size = new Size(224, 26);
            sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // imprimerToolStripMenuItem
            // 
            imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            imprimerToolStripMenuItem.Size = new Size(224, 26);
            imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(224, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // categorieToolStripMenuItem
            // 
            categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            categorieToolStripMenuItem.Size = new Size(224, 26);
            categorieToolStripMenuItem.Text = "Categorie";
            // 
            // groupeToolStripMenuItem
            // 
            groupeToolStripMenuItem.Name = "groupeToolStripMenuItem";
            groupeToolStripMenuItem.Size = new Size(224, 26);
            groupeToolStripMenuItem.Text = "Groupe";
            // 
            // FrmMenuPrincipal_cat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(894, 485);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal_cat";
            Text = "FrmMenuPrincipal_cat";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem categorieToolStripMenuItem;
        private ToolStripMenuItem groupeToolStripMenuItem;
        private ToolStripMenuItem sauvegarderToolStripMenuItem;
        private ToolStripMenuItem imprimerToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
    }
}