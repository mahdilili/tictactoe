using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie.Models
{
    static public class MesExtensions
    {
        static public int Tripler (this int iNombre)
        {
            return iNombre * 3;
        }
        static public string Inverser(this string sChaine)
        {
            string sChaineInversé = "";
            for (int iIndex = sChaine.Length-1; iIndex >= 0; iIndex--)
            {
                sChaineInversé += sChaine[iIndex];
            }
            return sChaineInversé;
        }
        static public string Répéter(this string sChaine,int iNbFois)
        {
            //Variables locales
            string sChaineRépétée = "";

            for (int i = 0; i< iNbFois; i++)
            {
                sChaineRépétée += sChaine;
            }
            return sChaineRépétée;
        }
    }
}
