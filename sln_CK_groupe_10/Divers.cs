using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetierCkGroupe10;

namespace Interface
{
    public class Divers
    {
        public static Boolean ExisteGroupe10(int pId)
        {
            Groupe10 unGroupe = new Groupe10(pId);

            // Vérifier si l'ID est nul ou invalide
            if (unGroupe.Groupe10Id == 0) // Vérification d'un int, 0 peut indiquer un ID non valide
            {
                return false;
            }
            else
            {
                // Comparer les IDs
                if (unGroupe.Groupe10Id == pId)
                {
                    return true;
                }
                return false;
            }
        }

    }
}

