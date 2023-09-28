using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InventaireAutomobiles.Models;
using InventaireAutomobiles.Views;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace InventaireAutomobiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constantes
        const string NOM_FICHIER = "automobiles.json";
        #endregion
        #region Champs
        private List<Automobile> _liste = new List<Automobile>() {
            new Automobile ()
            {
                Nom= "Bazou",
                Année = 1990,
                Constructeur="GM",
                Couleur = "Bleu",
                ID=1,
                Marque="Chevrolet",
                Modèle="Malibu",
                Neuf=true,

            }
        };
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            lstAutomobiles.ItemsSource = _liste;
            lstAutomobiles.Items.Refresh();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            frmAutomobile frmAuto = new frmAutomobile();
            Automobile auto = null;
            
            frmAuto.Owner = this; // le Main windows est ton papa.
            frmAuto.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            bool? bRetour = frmAuto.ShowDialog();       // Bloquant: La fenêtre doit être fermé pour revenir ici.

            if (bRetour == true)  // Bouton OK
            {
                // Ajouter l'automobile à la liste 
                auto = (Automobile)frmAuto.grdMain.DataContext;
                _liste.Add(auto);
                lstAutomobiles.Items.Refresh();
            }

        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            frmAutomobile frmAuto = new frmAutomobile();
            Automobile auto = null;

            frmAuto.Owner = this; // le Main windows est ton papa.
            frmAuto.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            if (lstAutomobiles.SelectedItem != null)
            {

                frmAuto.grdMain.DataContext = lstAutomobiles.SelectedItem;
                bool? bRetour = frmAuto.ShowDialog();       // Bloquant: La fenêtre doit être fermé pour revenir ici.

                if (bRetour == true)  // Bouton OK
                {
                    // Modifier l'automobile à la liste 
                    auto = (Automobile)frmAuto.grdMain.DataContext;
                    _liste[lstAutomobiles.SelectedIndex] = auto;
                    lstAutomobiles.Items.Refresh();

                }
            }
            else
                MessageBox.Show("Aucune automobile séléctionnée!", "ERREUR", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnEffacer_Click(object sender, RoutedEventArgs e)
        {
            //if (lstAutomobiles.SelectedIndex >= 0)
            //{
            //    _liste.RemoveAt(lstAutomobiles.SelectedIndex);
            //    lstAutomobiles.Items.Refresh();
            //}

            for (int iPos = 0; iPos < _liste.Count; iPos++)
            {
                if (_liste[iPos].Effacer == true)
                { 
                    _liste.Remove(_liste[iPos]);
                    iPos = 0;
                }
                lstAutomobiles.Items.Refresh();
            }
        }

        private void btnVider_Click(object sender, RoutedEventArgs e)
        {
            _liste.Clear();
            lstAutomobiles.Items.Refresh();

        }

        private void btnSauvegarder_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            string sJson = "";
            StreamWriter sw = null;

            //On sérialise donc objet vers texte 
            sJson = JsonSerializer.Serialize(_liste); //Texte en format JSON

            //Enregistrer dans le fichier 
            sw = new StreamWriter(NOM_FICHIER);
            sw.WriteLine(sJson);
            sw.Close();
        }

        private void btnCharger_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            string sJson = "";
            StreamReader sr = null;

            //Lire dans le fichier
            if(File.Exists(NOM_FICHIER))
            {
                sr = new StreamReader(NOM_FICHIER);
                sJson = sr.ReadToEnd();
                sr.Close();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true

                };
                //Désérialiser texte vers objet (liste)
                _liste = JsonSerializer.Deserialize<List<Automobile>>(sJson, options);
                
                //Appliquer les changements.
                lstAutomobiles.ItemsSource = _liste;
                lstAutomobiles.Items.Refresh();
            }
        }
    }
}
