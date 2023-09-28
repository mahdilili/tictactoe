using System;

namespace STHInformatique
{
    /// <summary>
    /// Auteur: 
    /// Description:   
    /// Date:   
    /// </summary>
    public class STHCryptage
    {
        #region Méthodes
        
        public string Encrypter(string sPhrase)
        {
            // Variables locales.
            string sEncryptée = "";

            for (int iIndex = 0; iIndex < sPhrase.Length; iIndex++)
                sEncryptée += (char)(sPhrase[iIndex] + 1);

            return sEncryptée;
        }

        public string Décrypter(string sPhrase)
        {
            // Variables locales.
            string sDécryptée = "";

            for (int iIndex = 0; iIndex < sPhrase.Length; iIndex++)
                sDécryptée += sPhrase[iIndex] - 1;

            return sDécryptée;
        }
        #endregion
    }
}
