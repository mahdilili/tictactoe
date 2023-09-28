using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie.Models.Commerce
{
 
    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un client.
    /// Date: 2013-04-05
    /// </summary>
    public class Client
    {
        #region Champ(s)
        // Champs

        #endregion

        #region Propriétés
        // Propriétés auto implémentées.
        public int NoClient { get; private set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
        #endregion

        #region Constructeur(s)
        // Constructeur
        public Client(int iNoClient, string sNom, string sVille)
        {
            NoClient = iNoClient;
            Nom = sNom;
            Ville = sVille;
        }
        #endregion
    }

    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un article.
    /// Date: 2013-04-05
    /// </summary>
    public class Article
    {
        #region Champ(s)
        // Champs

        #endregion

        #region Propriétés
        // Propriétés auto implémentées.
        public int NoArticle { get; private set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        #endregion

        #region Constructeur
        // Constructeur
        public Article(int iNoArtcile, string sNom, decimal dPrix)
        {
            NoArticle = iNoArtcile;
            Nom = sNom;
            Prix = dPrix;
        }
        #endregion
    }

    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un achat.
    /// Date: 2013-04-05
    /// </summary>
    public class Achat
    {
        #region Champ(s)
        // Champs
        #endregion

        #region Propriétés
        // Propriétés auto implémentées.
        public int NoVente { get; private set; }
        public string NoVendeur { get; private set; }
        public int NoClient { get; set; }
        public int NoArticle { get; set; }
        public int Quantite { get; set; }
        #endregion

        #region Constructeur
        // Constructeur
        public Achat(int iNoVente, string sNoVendeur, int iNoClient, int iNoArticle, int iQte)
        {
            NoVente = iNoVente;
            NoVendeur = sNoVendeur;
            NoClient = iNoClient;
            NoArticle = iNoArticle;
            Quantite = iQte;
        }
        #endregion
    }

    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un employé.
    /// Date: 2013-04-05
    /// </summary>
    public class Employe
    {
        #region Énumération(s)
        // Énumération
        public enum enumDivision { MTL, RVS, RVN };
        #endregion

        #region Propriétés
        // Propriétés auto-implémentées
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NoEmp { get; set; }
        public DateTime Naissance { get; set; }
        public enumDivision Division { get; set; }
        public byte Anciennete { get; set; }
        public string NoSucc { get; set; }
        #endregion

        #region Méthode(s)
        // Méthode(s)
        public override string ToString()
        {
            return NoEmp + " (" + Division + ") " + Nom + " " + Prenom + " (" + Naissance.ToShortDateString() + ") - Acienneté: " + Anciennete;
        }
        #endregion
    }
}
