using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CommonCkGroupe10;



namespace DataAccessCkGroupe10
{
    public class dbgroupe10
    {
       //déclaration d'un attribut de classe de type SqlConnection pour la connection à la BD
            SqlConnection SqlConX = null;
            //Méthode de fermeture de la connexion à la BD
            public void CloseConnexion()
            {
                if ((SqlConX != null) && SqlConX.State == ConnectionState.Open)
                {
                    SqlConX.Close();
                }
            }
            //Méthode SelectAll qui exécute la procédure stockée SPX_Utilisateur_SelectAll
            public DataTable SelectAll(string pUserNomComplet)
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_Utilisateur_SelectAll", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@CKgroupe10_NomPrenoms", SqlDbType.VarChar, 50);
                prm.Value = pUserNomComplet;
                cmd.Parameters.Add(prm);
                //récupération des données
                DataTable dt;
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //Remplissage du datatable
                da.Fill(dt);
                //Fermer la connexion
                CloseConnexion();
                return dt;
            }
        public string Insert(strGroupe10 pGroupe10)
        {
            try
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_Groupe10_Insert", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres
                SqlParameter prm;

                // Paramètre pour CKgroupe10_NomPrenoms (VARCHAR(50))
                prm = new SqlParameter("@CKgroupe10_NomPrenoms", SqlDbType.VarChar, 50);
                prm.Value = pGroupe10.CKgroupe10_NomPrenoms;
                cmd.Parameters.Add(prm);

                // Paramètre pour CKgroupe10_Date (DATETIME)
                prm = new SqlParameter("@CKgroupe10_Date", SqlDbType.DateTime);
                prm.Value = pGroupe10.CKgroupe10_Date;
                cmd.Parameters.Add(prm);

                // Paramètre pour CKgroupe10_Taille (DECIMAL(10, 2))
                prm = new SqlParameter("@CKgroupe10_Taille", SqlDbType.Decimal);
                prm.Value = pGroupe10.CKgroupe10_Taille;
                cmd.Parameters.Add(prm);

                // Paramètre pour categorield (VARCHAR(10))
                prm = new SqlParameter("@categorield", SqlDbType.VarChar, 10);
                prm.Value = pGroupe10.categorieId;
                cmd.Parameters.Add(prm);

                // Exécute la commande et récupère le résultat
                string res = (string)cmd.ExecuteScalar();

                CloseConnexion();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Supprimer(int pId)
        {
            try
            {
                //Définition de la chaine de connexion
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_Utilisateur_Delete", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@UserLogin", SqlDbType.VarChar, 10);
                prm.Value = pId;
                cmd.Parameters.Add(prm);
                string res = (string)cmd.ExecuteScalar();
                SqlConX.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IDataReader GetObject(int pId)
        {
            IDataReader dr = null;
            //Définition de la chaine de connexion
            SqlConX = mUtilities.maDBConnection();
            SqlConX.Open();
            //Commande
            SqlCommand cmd = new SqlCommand("SPX_Utilisateur_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Paramètres
            SqlParameter prm;
            prm = new SqlParameter("@UserLogin", SqlDbType.VarChar, 10);
            prm.Value = pId;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public bool Update(strGroupe10 pGroupe)
        {
            try
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_Groupe10_Update", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres en fonction des champs de la table CKGROUPE10
                SqlParameter prm;

                // Paramètre pour CKgroupe10_Id (type INT)
                prm = new SqlParameter("@CKgroupe10_Id", SqlDbType.Int);
                prm.Value = pGroupe.CKgroupe10_id;
                cmd.Parameters.Add(prm);

                // Paramètre pour CKgroupe10_NomPrenoms (type VARCHAR(50))
                prm = new SqlParameter("@CKgroupe10_NomPrenoms", SqlDbType.VarChar, 50);
                prm.Value = pGroupe.CKgroupe10_NomPrenoms;
                cmd.Parameters.Add(prm);

                // Paramètre pour CKgroupe10_Date (type DATETIME)
                prm = new SqlParameter("@CKgroupe10_Date", SqlDbType.DateTime);
                prm.Value = pGroupe.CKgroupe10_Date;
                cmd.Parameters.Add(prm);

                // Paramètre pour CKgroupe10_Taille (type DECIMAL(10,2))
                prm = new SqlParameter("@CKgroupe10_Taille", SqlDbType.Decimal);
                prm.Precision = 10;
                prm.Scale = 2;
                prm.Value = pGroupe.CKgroupe10_Taille;
                cmd.Parameters.Add(prm);

                // Paramètre pour categorield (type VARCHAR(10))
                prm = new SqlParameter("@categorield", SqlDbType.VarChar, 10);
                prm.Value = pGroupe.categorieId;
                cmd.Parameters.Add(prm);

                // Exécuter la requête
                int rowsAffected = cmd.ExecuteNonQuery();

                CloseConnexion();
                return rowsAffected > 0; // Retourne vrai si une ligne a été mise à jour
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
