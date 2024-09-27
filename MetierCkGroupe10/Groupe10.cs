using DataAccessCkGroupe10;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonCkGroupe10;
using DataAccessCkGroupe10;

namespace MetierCkGroupe10
{
    public class Groupe10
    {
        // Définition des attributs
        int _groupe10Id;
        string _groupe10NomPrenoms;
        DateTime _groupe10Date;
        decimal _groupe10Taille;
        string _categorieId;

        // Définition des propriétés ou accesseurs
        public int Groupe10Id
        {
            get { return _groupe10Id; }
            set { _groupe10Id = value; }
        }

        public string Groupe10NomPrenoms
        {
            get { return _groupe10NomPrenoms; }
            set { _groupe10NomPrenoms = value; }
        }

        public DateTime Groupe10Date
        {
            get { return _groupe10Date; }
            set { _groupe10Date = value; }
        }

        public decimal Groupe10Taille
        {
            get { return _groupe10Taille; }
            set { _groupe10Taille = value; }
        }

        public string CategorieId
        {
            get { return _categorieId; }
            set { _categorieId = value; }
        }


        // Définition de la structure
         strGroupe10 MyStructure
        {
            get
            {
                strGroupe10 st = new strGroupe10();

                // Utilisation des propriétés publiques avec des types appropriés
                st.CKgroupe10_id = this._groupe10Id;                     // Type INT
                st.CKgroupe10_NomPrenoms = this._groupe10NomPrenoms;     // Type VARCHAR(50)
                st.CKgroupe10_Date = this._groupe10Date;                 // Type DATETIME
                st.CKgroupe10_Taille = this._groupe10Taille;             // Type DECIMAL(10, 2)
                st.categorieId = this.CategorieId;                         // Type VARCHAR(10)

                return st;
            }
        }



        // Mapping des données à partir du DataReader
        public void MapFromDataReader(IDataReader dreader)
            {
                if (!(DBNull.Value.Equals(dreader["CKgroupe10_Id"])))
                {
                    _groupe10Id = (int)dreader["CKgroupe10_Id"];
                }
                if (!(DBNull.Value.Equals(dreader["CKgroupe10_NomPrenoms"])))
                {
                    _groupe10NomPrenoms = (string)dreader["CKgroupe10_NomPrenoms"];
                }
                if (!(DBNull.Value.Equals(dreader["CKgroupe10_Date"])))
                {
                    _groupe10Date = (DateTime)dreader["CKgroupe10_Date"];
                }
                if (!(DBNull.Value.Equals(dreader["CKgroupe10_Taille"])))
                {
                    _groupe10Taille = (decimal)dreader["CKgroupe10_Taille"];
                }
                if (!(DBNull.Value.Equals(dreader["categorield"])))
                {
                    _categorieId = (string)dreader["categorield"];
                }
            }

            // Sélectionner tous les éléments en fonction d'un nom
            public static DataTable SelectAll(string pNomPrenoms)
            {
                dbgroupe10 undbGroupe = new dbgroupe10();
                DataTable dt = undbGroupe.SelectAll(pNomPrenoms);
                return dt;
            }

            // Insertion d'un nouvel élément
            public void Insert()
            {
                dbgroupe10 undbGroupe = new dbgroupe10();
                undbGroupe.Insert(this.MyStructure);
            }

        // Mise à jour d'un élément
        public void Update()
        {
            dbgroupe10 undbGroupe = new dbgroupe10();
            undbGroupe.Update(this.MyStructure);
        }

        // Suppression d'un élément par Id
        public void Supprimer(int pId)
            {
                dbgroupe10 undbGroupe = new dbgroupe10();
                undbGroupe.Supprimer( pId);
            }

            // Constructeur avec ID
            public Groupe10(int pId)
            {
                dbgroupe10 db = new dbgroupe10();
                IDataReader dreader = db.GetObject(pId);
                if (dreader.Read())
                {
                    this.MapFromDataReader(dreader);
                }
                db.CloseConnexion();
            }

            // Constructeur sans paramètre
            public Groupe10()
            { }
        }

    }


