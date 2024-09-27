using MetierCkGroupe10;
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
    public partial class frmGroupeDétails : Form
    {
        char vOptionAppel = 'n'; //attribut permettant de définir le contexte d'appel ('n','m','c','s')
        string vTitre = "";//permet de définir le titre du formulaire en fonction du contexte d'appel
        Groupe10 CurrentGroupe10 = null;// objet métier contenant l'utilisateur en cours de traitement

        public frmGroupeDétails()
        {
            InitializeComponent();
            InitForm(vOptionAppel);

        }
        public frmGroupeDétails(Groupe10 LeGroupe, char pOptionAppel)

        {
            InitializeComponent();
            CurrentGroupe10 = LeGroupe;//réccupération de l'utilisateur courant dans l'attribut CurrentUser
            vOptionAppel = pOptionAppel; //affectation de l'option d'appel dans l'attribut vOptionAppel
            InitForm(vOptionAppel);// méthode d'initialisation du titre et des contrôles du formulaire selon l'option d'appel
            ChargerLeGroupe(LeGroupe);//méthode d'affichage de l'utilisateur en cours de traitement
        }
        private void ChargerLeGroupe(Groupe10 LeGroupe)
        {
            if (LeGroupe != null)
            {
                // Vérification et affectation des propriétés du groupe aux champs du formulaire
                if (!string.IsNullOrEmpty(LeGroupe.Groupe10NomPrenoms))
                {
                    txtNomPrenom.Text = LeGroupe.Groupe10NomPrenoms;
                }

                if (!string.IsNullOrEmpty(LeGroupe.CategorieId))
                {
                    txtCatDesignation.Text = LeGroupe.CategorieId;
                }

                // L'ID est auto-incrémenté et non modifiable, donc on n'a pas besoin de le charger ici
            }
            else
            {
                // Réinitialisation des champs si LeGroupe est nul
                txtNomPrenom.Text = string.Empty;
                txtCatDesignation.Text = string.Empty;
                // L'ID n'est pas modifiable, donc pas besoin de réinitialiser
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (OkSaisie()) // Vérifie que la saisie est valide
            {
                MappFormToObject(); // Remplit l'objet Groupe10 avec les données du formulaire

                switch (vOptionAppel)
                {
                    case 'n': // Nouvelle entrée
                        if (!Divers.ExisteGroupe10(Convert.ToInt32(txtGroupe_Id.Text))) // Vérifie si le Groupe existe déjà
                        {
                            CurrentGroupe10.Insert(); // Insère un nouveau Groupe
                            MessageBox.Show("Le groupe a été enregistré", Application.ProductName, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Risque de doublon. La saisie ne sera pas enregistrée", Application.ProductName, MessageBoxButtons.OK);
                        }
                        break;

                    case 'c': // Option à ajouter si nécessaire (peut-être une consultation ou autre logique)
                        break;

                    //case 'm': // Modification d'une entrée existante
                    //    if (Divers.ExisteGroupe10(Convert.ToInt32(txtGroupe_Id.Text))) // Vérifie que le Groupe existe
                    //    {
                    //        CurrentGroupe10.Update(); // Met à jour le Groupe
                    //        MessageBox.Show("Les modifications ont été enregistrées", Application.ProductName, MessageBoxButtons.OK);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("ID du groupe inexistant ! Les modifications ont été ignorées", Application.ProductName, MessageBoxButtons.OK);
                    //    }
                    //    break;

                    case 's': // Suppression d'un Groupe
                        CurrentGroupe10.Supprimer(Convert.ToInt32(txtGroupe_Id.Text)); // Supprime le Groupe par son ID
                        MessageBox.Show("Le groupe a été désactivé", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        break;
                }

                this.Close(); // Ferme le formulaire après l'enregistrement
            }

        }
        private void InitForm(char optionAppel)
        {
            switch (optionAppel)
            {
                case 'n':
                    vTitre = "Nouveau groupe";
                    // Configuration des contrôles pour un nouveau groupe
                    break;
                case 'm':
                    vTitre = "Modifier groupe";
                    // Configuration des contrôles pour la modification d'un groupe
                    break;
                case 'c':
                    vTitre = "Consulter groupe";
                    // Configuration des contrôles pour la consultation d'un groupe
                    break;
                case 's':
                    vTitre = "Supprimer groupe";
                    // Configuration des contrôles pour la suppression d'un groupe
                    break;
                default:
                    vTitre = "Détail groupe";
                    // Configuration par défaut
                    break;
            }
            this.Text = vTitre; // Mise à jour du titre de la fenêtre
        }

        private void MappFormToObject()
        {
            // Crée un nouvel objet Groupe10 et affecte les champs du formulaire aux propriétés de l'objet
            CurrentGroupe10 = new Groupe10();

            // Remplir les champs de l'objet avec les valeurs saisies dans les contrôles du formulaire
            if (int.TryParse(txtGroupe_Id.Text, out int groupeId))
            {
                CurrentGroupe10.Groupe10Id = groupeId; // Assigner l'ID du groupe (de type int)
            }

            CurrentGroupe10.Groupe10NomPrenoms = txtNomPrenom.Text; // Assigner le nom et prénoms (de type string)

            //if (DateTime.TryParse(tx.Text, out DateTime date))
            //{
            //    CurrentGroupe10.Groupe10Date = date; // Assigner la date (de type DateTime)
            //}

            //if (decimal.TryParse(tx.Text, out decimal taille))
            //{
            //    CurrentGroupe10.Groupe10Taille = taille; // Assigner la taille (de type decimal)
            //}

            if (!string.IsNullOrEmpty(txtCatDesignation.Text))
            {
                CurrentGroupe10.CategorieId = txtCatDesignation.Text; // Assigner la catégorie (de type string)
            }
        }
        private bool OkSaisie()
        {
            // Vérifie si le champ Nom et Prénoms est rempli
            if (string.IsNullOrEmpty(txtNomPrenom.Text))
            {
                MessageBox.Show("Nom et prénoms du groupe attendus", Application.ProductName, MessageBoxButtons.OK);
                txtNomPrenom.Focus();
                return false;
            }

          

            // Vérifie si l'ID de la catégorie est rempli
            if (string.IsNullOrEmpty(txtCatDesignation.Text))
            {
                MessageBox.Show("ID de la catégorie attendu", Application.ProductName, MessageBoxButtons.OK);
                txtCatDesignation.Focus();
                return false;
            }

            // Si tous les champs sont valides, la saisie est correcte
            return true;
        }


    }
}
