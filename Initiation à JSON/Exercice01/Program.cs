using System;
using System.Collections.Generic;
using Exercice01.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Exercice01
{
    class Program
    {
        #region Constantes
        const string NOM_FICHIER = "restos.json";
        #endregion
        #region Champs
        static List<Restaurant> _liste = new List<Restaurant>()
        {
            new Restaurant()
            {
                Nom="Au vieu duluth",
                Adresse="3000 ave Boullé",
                Téléphone="541-273-2227",
                NbPlaces=100,
                ApporterVin=true
            }
        };
        #endregion
        #region Méthodes
        static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1) Afficher la liste des restaurants");
            Console.WriteLine(" 2) Ajouter un restaurant");
            Console.WriteLine(" 3) Retirer un restaurant");
            Console.WriteLine(" 4) Sauvegarder la liste");
            Console.WriteLine(" 5) Charger la liste");
            Console.WriteLine(" Q) Quitter");
            Console.Write(" Votre choix: ");

        }
        static void Pause()
        {
            Console.WriteLine("APPUYEZ SUR UNE TOUCHE...");
            Console.ReadKey();
        }
        static void RetirerRestaurant()
        {
            //Variables locales 
            byte byIndex = 0;
            bool bValid = false;
            string sRéponse = "";
            do
            {
                AfficherListe(false);
                Console.Write("Entrer le numéro du restaurant à éffacer: ");
                sRéponse = Console.ReadLine();
                if (sRéponse.ToUpper() == "X") // Annuler le retrait
                    bValid = true;
                else
                {
                    bValid = byte.TryParse(sRéponse, out byIndex) &&
                        byIndex >= 1 &&
                        byIndex <= _liste.Count;

                    if (bValid)
                    {
                        _liste.RemoveAt(byIndex - 1);
                        AfficherListe();
                    }
                   
                }
            } while (!bValid);
        }
        static void AfficherListe(bool bPause =true)
        {
            //Variables locales
            int iPos = 1;
            Console.WriteLine("Liste des restaurants: ");
            Console.WriteLine("Nom\t\t Adresse \t\t Téléphone\t\t Nombre de places \t\t Vin");
            foreach (Restaurant resto in _liste)
            {
                Console.WriteLine($"{iPos}) {resto.Nom}\t {resto.Adresse}\t {resto.Téléphone}\t\t {resto.NbPlaces}\t\t {resto.ApporterVin}");
                iPos++;
            }
                if (bPause)
            Pause();
        }
        static void AjouterRestaurant()
        {
            //Variables locales
            Restaurant resto = new Restaurant();
            string sRéponse = "";
            byte byNbPlaces = 0;
            bool bValid = false;

            Console.Write("Entrer le nom du restaurant: ");
            resto.Nom = Console.ReadLine();

            Console.Write("Entrer l'adresse du restaurant: ");
            resto.Adresse = Console.ReadLine();

            Console.Write("Entrer le téléphone du restaurant: ");
            resto.Adresse = Console.ReadLine();

            do
            {
                Console.Write("Entrer le nombre de places: ");
                sRéponse = Console.ReadLine();

            } while (!byte.TryParse(sRéponse,out byNbPlaces));
            resto.NbPlaces = byNbPlaces;

            do
            {
                Console.Write("Peut-on apporter notre vin (O/N): ");
                sRéponse = Console.ReadLine();
                if (sRéponse.ToUpper() == "O" || sRéponse.ToUpper() == "N")
                {
                    resto.ApporterVin = sRéponse == "O" ? true : false;
                    bValid = true;
                }
                else
                    bValid = false;
            } while (!bValid);

            //Ajouter le restaurant 
            _liste.Add(resto);
           
        }

        static void SauvegarderListe()
        {
            // Variables locales
            string sJson = "";
            StreamWriter sw = null;
            //Convertir liste en mémoire vers texte JSON
            sJson = JsonSerializer.Serialize(_liste);

            sw = new StreamWriter(NOM_FICHIER);
            sw.WriteLine(sJson);
            sw.Close();
        }
        static void ChargerListe()
        {
            //Variables locales 
            string sjson = "";
            StreamReader sr = null;

            //Lire le fichier JSON
            if (File.Exists(NOM_FICHIER))
            {
                sr = new StreamReader(NOM_FICHIER);
                sjson = sr.ReadToEnd();
                sr.Close();

                //Désérialiser le texte JSON
                _liste = JsonSerializer.Deserialize<List<Restaurant>>(sjson);
            }


        }
        #endregion
        static void Main(string[] args)
        {
            //Variables locales
            char cChoix = ' ';
            do
            {
                AfficherMenu();
                cChoix = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (cChoix)
                {
                    case '1':   AfficherListe();
                        break;
                    case '2':   AjouterRestaurant();
                        break;
                    case '3':   RetirerRestaurant();
                        break;
                    case '4':   SauvegarderListe();
                        break;
                    case '5':   ChargerListe();
                        break;
                    default:
                        break;
                }
            } while (char.ToUpper(cChoix) != 'Q');
        }
    }
}
