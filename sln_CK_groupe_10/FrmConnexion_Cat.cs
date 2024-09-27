using sln_CK_groupe_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmConnexion_Cat : Form
    {
        public FrmConnexion_Cat()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           /* if (Divers.ExisteUtilisateur(txtNom.Text))
            {
                Utilisateur unUser = new Utilisateur(txtNom.Text);
                if (unUser.UserLogin.ToUpper() == txtNom.Text.ToUpper() && unUser.UserMotPass.ToUpper() == txtMotDePasse.Text.ToUpper())
                {
                    //this.Visible = false;
                    txtNom.Text = unUser.UserLogin;
                    txtMotDePasse.Text = unUser.UserNomComplet;
                    cbRôle.Text = unUser.UsercbRôle;
                    frmMenuPrincipal frm = new frmMenuPrincipal();
                    frm.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("LOGIN ou MOT DE PASSE incorrectes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Le LOGIN NAME est inexistant", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }
    }
    
}
