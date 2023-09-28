using System;

namespace ExercicesLib
{
    /// <summary>
    /// Auteur: Mahdi Ellili
    /// Description: Permet d'encrypter et décrypter des messages.
    /// Date: 2022-03-18
    /// </summary>
    public class STHCryptage
    {
        #region Méthodes
        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: encrypter une phrase décalé de 1.
        /// Date:2022-03-18
        /// </summary>
        /// <param name="sPhrase">Phrase à encrypter</param>
        /// <returns></returns>
        public string Encrypter(string sPhrase)
        {
            //Variables locales.
            string sPhraseCryptée = "";
            for (int iPos = 0; iPos < sPhrase.Length; iPos++)
            {
                sPhraseCryptée +=(char) ((int)sPhrase[iPos] + 1);
            }
            return sPhraseCryptée;
        }

        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description:Décrypter une phrase décalée de 1.
        /// Date:2022-03-18
        /// </summary>
        /// <param name="sPhraseCryptée">Phrase à décrypter</param>
        /// <returns>Phrase normale</returns>
        public string Décrypter (string sPhraseCryptée)
        {
            //Variables locales
            string sPhrase= "";
            for (int iPos = 0; iPos < sPhraseCryptée.Length; iPos++)
            {
                sPhrase += (char)((int)sPhraseCryptée[iPos] - 1);
            }
            return sPhrase;
        }
        
        #endregion
    }
}
