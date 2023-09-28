using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Théorie.Views
{
    partial class MainWindow : Window
    {
        #region Champs
        private List<string> _mots = new List<string>() { "LINQ", "est", "un", "outil", "pratique",
                                                                 "puissant", "et", "très", "polyvalent", "et",
                                                                 "saisissant","pis"};

        // Liste de prénoms
        private List<string> _prenoms = new List<string>() { "Marc", "Anthony", "Carl", "Isabelle", "Marie", "Laurie","L" };

        // Liste de nombres entiers
        private List<int> _nombres = new List<int>() { 40, 5, 90, 123, 2, 33, 210, 101, 78, 21 };

        // Liste de montants des ventes
        private double[] _ventes = new double[] { 
                                                         1277.49, 	2630.52, 	3486.01, 	1433.41, 
                                                         3261.82, 	3941.89, 	 964.27, 	1554.94, 
                                                         2606.12, 	1455.55, 	3602.83, 	3820.86, 
                                                          792.15, 	2170.34, 	2573.55, 	3023.17, 
                                                         3165.32, 	1921.81, 	2667.28, 	3667.19, 
                                                          662.13, 	1027.72, 	2806.66, 	2792.63, 
                                                         2567.80, 	3318.65, 	 660.59, 	1196.25, 
                                                         3827.95, 	 663.32, 	3378.49, 	1122.84, 
                                                          681.87, 	2904.26, 	1207.63, 	 441.00,
                                                         2135.93, 	3370.82, 	3631.19, 	1277.98
                                                      };
        #endregion
    }
}
