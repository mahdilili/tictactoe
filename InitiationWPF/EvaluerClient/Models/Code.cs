using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluerClient.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Code
    {/// <summary>
     /// Auteur:Mahdi Elllili
     /// Description:Produire le code spécial selon le format : 
     ///                 NNNPAAMMJJ
     ///                 - NNN : Trois premiers caractères du nom de famille (maj)
     ///- P : Premier caractère du prénom(maj)
     ///- AA : Deux derniers chiffres de l’année
     ///- MM : Deux derniers chiffres du mois
     ///- JJ : Deux derniers chiffres du jour
     ///Date : 2022-03-25
     /// </summary>
     /// <param name="Prénom">Prénom de la personne</param>
     /// <param name="sNom">nom de famille de la personne</param>
     /// <param name="Naissance">date de naissance de la personne</param>
     /// <returns>code spécial selon le format NNNPAAMMJJ</returns>
        public string CréerCodeSpécia(string sPrénom, string sNom, DateTime? Naissance)
        {
            //Varibales locales

            string sCodeSpécial = "";

            if(sNom.Length >=3)
                 sCodeSpécial += sNom.Substring(0, 3).ToUpper();       // NNN
            if(sPrénom.Length >=1)
                 sCodeSpécial += char.ToUpper(sPrénom[0]);             // P
            if (Naissance != null)
            {
                sCodeSpécial += Naissance?.Year.ToString().Substring(2, 2);  // AA
                sCodeSpécial += Naissance?.Month.ToString("00"); // MM
                sCodeSpécial += Naissance?.Day.ToString("00");   // JJ
            }

            return sCodeSpécial;
        }
    }
}
