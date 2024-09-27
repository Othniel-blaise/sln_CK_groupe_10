using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommonCkGroupe10
{
    public class mUtilities
    {
        public static SqlConnection maDBConnection()
        {
            //définition de la chaine de connexion
            string conxstr = @"Data Source=DESKTOP-45QG60P\SQLEXPRESS;Initial Catalog=dbCKgroupe10;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection conX = new SqlConnection(conxstr);
            return conX;
        }
    }
}
