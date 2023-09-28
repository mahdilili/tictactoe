using InitiationClasses.Models;
using System;

namespace InitiationClasses
{
    /// <summary>
    /// Auteur:Mahdi Ellili
    /// Description: Programme qui sert à évaluer le niveau de pollution à partir d'une valeur
    /// Date:2022-03-16
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Variables locales.
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Rectangle r3 = new Rectangle(7, 8);
            Rectangle r4 = new Rectangle("6", "9");
            Rectangle r5 = new Rectangle((byte)5, (byte)8);
            Rectangle r6 = new Rectangle()
            {
                //Initialiseurs
                Hauteur = 9,
                Largeur = 10
            };
            Etudiant e1 = new Etudiant();
            Etudiant e2 = new Etudiant("Roy", "Carl", "1234567", new DateTime(2002, 06, 07));
            Etudiant.ValidationNote Valide = Etudiant.ValidationNote.Succès;

            //utiliser un rectangle 
            //r1.DéfinirValeurs(12, 20);
            r1.Hauteur = 12;
            r1.Largeur = 20;
            
            Console.WriteLine("r1 (surface): " + r1.Surface);
           // r1.Hauteur = 30;
           // int iValeur = 10 + r1.Hauteur;         //get
           // Console.WriteLine(iValeur);

            //utiliser un étudiant.
            e1.DefinirInfos("Tremblay", "Carl", "0234789", DateTime.Parse("1996-06-09"));
            Valide = e1.AttribuerNote(88, 1);
            if(Valide!=Etudiant.ValidationNote.Succès)
                Console.WriteLine("ERREUR: Problème de note #1! : "+Valide);

            Valide = e1.AttribuerNote(100, 2);
            if (Valide != Etudiant.ValidationNote.Succès)
                Console.WriteLine("ERREUR: Problème de note #2! : " + Valide);

            Valide = e1.AttribuerNote(70, 3);
            if (Valide != Etudiant.ValidationNote.Succès)
                Console.WriteLine("ERREUR: Problème de note #3! : " + Valide);

            Valide = e1.AttribuerNote(85, 4);
            if (Valide != Etudiant.ValidationNote.Succès)
                Console.WriteLine("ERREUR: Problème de note #4! : " + Valide);

            Valide = e1.AttribuerNote(101, 5);
            if (Valide != Etudiant.ValidationNote.Succès)
                Console.WriteLine("ERREUR: Problème de note #5! : " + Valide);

            // e1._abyNotes[1] = 100;
            // e1._abyNotes[2] = 70;
            // e1._abyNotes[3] = 85;
            // e1._abyNotes[4] = 100;
            Console.WriteLine("Etudiant #1 (Infos): "+ 
                e1.ObtenirSommaire());


            #region Personne
            Personne p1 = new Personne()
            {
                Nom = "Tremblay", //Initialiseur
                Prénom = "Marc",
                Age = 34,
                Téléphone = "(450) 123-1234", //set
                Adresse = "3000 ave boullé"
            };

            Personne p2 = new Personne();
          
            p2.Nom = "Roy";
            p2.Prénom = "Ginette";
            p2.Age = 26;
            p2.Adresse = "30 des érables";

            Personne p3 = new Personne();
            p3.Nom = "Savard";
            p3.Prénom = "Luc";
            p3.Age = 43;

            Console.WriteLine("P1: "+p1.Prénom +" "+ p1.Nom + ", Vie en heures: " + p1.CalculerDuréeVieEnHeures());
            Console.WriteLine("P2: " + p2.Prénom + " " + p2.Nom + ", Vie en heures: " + p2.CalculerDuréeVieEnHeures());
            Console.WriteLine("P3: " + p3.Prénom + " " + p3.Nom + ", Vie en heures: " + p3.CalculerDuréeVieEnHeures());

            #endregion

            
        }
    }

}
