using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Théorie.Models.Commerce;
using System.Windows;

namespace Théorie.Views
{
    partial class MainWindow : Window
    {
        // Liste d'employés d'une compagnie
        private List<Employe> _employes = new List<Employe>()
        {
            #region Données 
            new Employe() { Nom="Roy",      Prenom="Luc",     Division=Employe.enumDivision.MTL, NoEmp="E00001", Anciennete=10, Naissance= new DateTime(1980,01,23), NoSucc="0002" },
            new Employe() { Nom="Savard",   Prenom="Roger",   Division=Employe.enumDivision.RVS, NoEmp="E00002", Anciennete=3,  Naissance= new DateTime(1995,08,10), NoSucc="0003" },
            new Employe() { Nom="Tremblay", Prenom="Lucie",   Division=Employe.enumDivision.RVS, NoEmp="E00003", Anciennete=4,  Naissance= new DateTime(1991,04,09), NoSucc="0001" },
            new Employe() { Nom="Simard",   Prenom="Élise",   Division=Employe.enumDivision.RVN, NoEmp="E00004", Anciennete=20, Naissance= new DateTime(1975,06,13), NoSucc="0001" },
            new Employe() { Nom="Savard",   Prenom="Marc",    Division=Employe.enumDivision.MTL, NoEmp="E00005", Anciennete=15, Naissance= new DateTime(1978,11,07), NoSucc="0004" },
            new Employe() { Nom="Côté",     Prenom="Luc",     Division=Employe.enumDivision.MTL, NoEmp="E00006", Anciennete=11, Naissance= new DateTime(1993,07,21), NoSucc="0003" },
            new Employe() { Nom="Mercure",  Prenom="Renée",   Division=Employe.enumDivision.RVN, NoEmp="E00007", Anciennete=10, Naissance= new DateTime(1981,02,15), NoSucc="0004" },
            new Employe() { Nom="Roy",      Prenom="Marcel",  Division=Employe.enumDivision.RVS, NoEmp="E00008", Anciennete=8,  Naissance= new DateTime(1997,01,09), NoSucc="0002" },
            new Employe() { Nom="Turcotte", Prenom="Roger",   Division=Employe.enumDivision.MTL, NoEmp="E00009", Anciennete=31, Naissance= new DateTime(1954,10,07), NoSucc="0002" },
            new Employe() { Nom="Lavigne",  Prenom="Isidore", Division=Employe.enumDivision.RVN, NoEmp="E00010", Anciennete=4,  Naissance= new DateTime(1997,05,18), NoSucc="0001" }
            #endregion
        };

        public List<Client> _clients = new List<Client>() 
        {   
            #region Données 
            // NoClient attribué par le constructeur
            // Nom, Ville
            new Client( 1, "Jacques", "Saint-Hyacinthe"),
            new Client( 2, "André",   "Saint-Hyacinthe" ),
            new Client( 3, "Josée",   "Ste-Julie" ),      
            new Client( 4, "Aline",   "Saint-Hilaire"),   
            new Client( 5, "Roger",   "Ste-Julie")   
            #endregion     
        };

        public List<Article> _articles = new List<Article>() 
        { 
            #region Données 
            // NoArticle attribué par le constructeur
            // Nom, Prix
            new Article( 1001, "PC Portable", 1200 ), 
            new Article( 1002, "PC Bureau ",  1000 ), 
            new Article( 1003, "Souris", 30 ),        
            new Article( 1004, "HDD 500G ", 75 ),     
            new Article( 1005, "HDD 1T", 120 ),       
            new Article( 1006, "USB 4G", 25 ),        
            new Article( 1007, "USB 8G", 75 ),        
            new Article( 1008, "USB 16G", 150 ) 
            #endregion        
        };

        public List<Achat> _achats = new List<Achat>() 
        {   
            #region Données 
            // NoVente, NoClient, NoArticle, Qte
            new Achat(3001, "E00001", 1, 1001, 1 ),
            new Achat(3002, "E00004", 2, 1002, 1 ),
            new Achat(3003, "E00002", 1, 1006, 2 ),
            new Achat(3004, "E00007", 3, 1005, 1 ),
            new Achat(3005, "E00001", 2, 1004, 1 ),
            new Achat(3006, "E00007", 1, 1003, 1 ),
            new Achat(3007, "E00007", 3, 1008, 1 ),
            new Achat(3008, "E00001", 4, 1006, 20 ),
            new Achat(3009, "E00002", 2, 1003, 1 ),
            new Achat(3010, "E00004", 4, 1004, 20 )
            #endregion 
        };
    };
}
