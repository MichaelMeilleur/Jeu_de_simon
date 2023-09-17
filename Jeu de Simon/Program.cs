using System;

namespace Jeu_de_Simon
{
    /// <summary>
    /// Auteur: Michael Meilleur
    /// Description: Application de type console basée sur le jeu de Simon simplifié. 
    /// Le jeu consiste à allumer une couleur, puis ajouter au hasard une nouvelle couleur par la suite.
    /// Le joueur doit reproduire cette nouvelle séquence. Chaque fois que le joueur reproduit
    /// correctement la séquence, le jeu ajoute une nouvelle couleur supplémentaire.
    /// Date: 2021-11-04
    /// </summary>
    class Program
    {
        #region Variables globales (champs)
        static Random _rnd = new Random();
        #endregion

        #region Méthodes

        /// <summary>
        /// Auteur: Michael Meilleur
        /// Description: Afficher les cubes de couleurs.
        /// Date: 2021-11-04
        /// </summary>
        static private void AfficherCubes()
        {
            Console.WriteLine("======== Jeu de Simon =========");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   1   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   2   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("   3   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("   4   ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.WriteLine("===============================");
        }

        /// <summary>
        /// Auteur: Michael Meilleur
        /// Description: Afficher en blanc le cube #1.
        /// Date: 2021-11-04
        /// </summary>
        static private void AfficherCubeBlanc1()
        {
            Console.WriteLine("======== Jeu de Simon =========");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("   1   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   2   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("   3   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("   4   ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.WriteLine("===============================");
        }

        /// <summary>
        /// Auteur: Michael Meilleur
        /// Description: Afficher en blanc le cube #2.
        /// Date: 2021-11-04
        /// </summary>
        static private void AfficherCubeBlanc2()
        {
            Console.WriteLine("======== Jeu de Simon =========");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   1   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("   2   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("   3   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("   4   ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.WriteLine("===============================");
        }

        /// <summary>
        /// Auteur: Michael Meilleur
        /// Description: Afficher en blanc le cube #3.
        /// Date: 2021-11-04
        /// </summary>
        static private void AfficherCubeBlanc3()
        {
            Console.WriteLine("======== Jeu de Simon =========");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   1   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   2   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("   3   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("   4   ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.WriteLine("===============================");
        }

        /// <summary>
        /// Auteur: Michael Meilleur
        /// Description: Afficher en blanc le cube #4.
        /// Date: 2021-11-04
        /// </summary>
        static private void AfficherCubeBlanc4()
        {
            Console.WriteLine("======== Jeu de Simon =========");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("   1   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   2   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("   3   ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("   4   ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("       ");
            Console.ResetColor();
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("       ");
            Console.ResetColor();

            Console.WriteLine("===============================");
        }

        /// <summary>
        /// Auteur: Michael Meilleur.
        /// Description: Animation des cubes lors de la séquence.
        /// Date: 2021-11-11
        /// </summary>
        static private void AnimationJeu()
        {
            Console.WriteLine("En cours d'animation...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            AfficherCubes();
            Console.WriteLine("En cours d'animation...");
            System.Threading.Thread.Sleep(1000);
        }

        #endregion
        static void Main(string[] args)
        {
            // Variables locales.
            string sSéquence = "";
            string sRéponseSéquence = "";
            byte[] abyNombre = new byte[255];
            bool bQuitter = false;
            int iNbFoisTrouvé = 0;
            int iRecordFoisTrouvé = 0;
            char cChoix = ' ';
            int iCpt = 0;

            // Afficher les cubes et débuter le jeu.
            AfficherCubes();
            Console.WriteLine("Appuyer sur une touche pour débuter...");
            Console.ReadKey();

            // Allouer le tableau en mémoire.
            abyNombre = new byte[255];

            // Remplir le tableau.
            for (byte byIndex = 0; byIndex <= abyNombre.Length - 1; byIndex++)
            {
                abyNombre[byIndex] = (byte)_rnd.Next(1, 5); // Remplir le tableau aléatoirement.
            }

            do
            {
                // Animation des tours.
                for (byte byIndex = 0; byIndex <= iCpt; byIndex++)
                {
              
                    sSéquence += abyNombre[byIndex];  // Cumul de la séquence.

                    if (abyNombre[byIndex] == 1)
                    {
                        Console.Clear();
                        AfficherCubeBlanc1();
                        AnimationJeu();
                    }
                    else
                    {
                        if (abyNombre[byIndex] == 2)
                        {
                            Console.Clear();
                            AfficherCubeBlanc2();
                            AnimationJeu();
                        }
                        else
                        {
                            if (abyNombre[byIndex] == 3)
                            {
                                Console.Clear();
                                AfficherCubeBlanc3();
                                AnimationJeu();
                            }
                            else
                            {
                                if (abyNombre[byIndex] == 4)
                                {
                                    Console.Clear();
                                    AfficherCubeBlanc4();
                                    AnimationJeu();
                                }
                            }
                        }
                    }
                }

                // Demander la séquence au joueur.
                Console.Clear();
                AfficherCubes();
                Console.WriteLine("Animation terminée! ");
                Console.WriteLine("");
                Console.WriteLine("Entrer votre séquence: ");
                sRéponseSéquence = Console.ReadLine();


                // Validation de la séquence.
                if (sRéponseSéquence == "q" || sRéponseSéquence == "Q")
                {
                    Console.WriteLine("Au revoir!");
                    bQuitter = true;
                }
                else
                {
                    if (sRéponseSéquence == sSéquence)
                    {
                        iCpt++;
                        iNbFoisTrouvé++;
                        sSéquence = ""; // Remettre la séquence a zéro.
                        Console.WriteLine("BRAVO! Vous avez suivi la séquence! On ajoute un tour.");
                        Console.WriteLine("APPUYER SUR UNE TOUCHE...");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (sRéponseSéquence != sSéquence)
                        {
                            Console.WriteLine("ERREUR: Mauvaise séquence!");
                            Console.WriteLine("Nombre de fois trouvé...........: " + iNbFoisTrouvé);
                            if (iNbFoisTrouvé > iRecordFoisTrouvé)
                            {
                                iRecordFoisTrouvé = iNbFoisTrouvé;
                            }
                            else
                                iRecordFoisTrouvé = iRecordFoisTrouvé;
                            Console.WriteLine("Record du nombre de fois trouvé.: " + iRecordFoisTrouvé);
                            Console.WriteLine("Voulez-vous recommencer (o/n)?");

                            // Lire le choix.
                            cChoix = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                            switch (cChoix)
                            {
                                case 'o':
                                    iCpt = 0; // Remettre le compteur à zéro.
                                    sSéquence = ""; // Remettre la séquence a zéro.
                                    iNbFoisTrouvé = 0; // Remettre le nombre de fois trouvé à zéro.
                                    for (byte byIndex = 0; byIndex <= abyNombre.Length - 1; byIndex++) // Générer un nouveau tableau.
                                    {
                                        abyNombre[byIndex] = (byte)_rnd.Next(1, 5); 
                                    }
                                    Console.Clear();
                                    AfficherCubes();
                                    Console.WriteLine("Appuyer sur une touche pour débuter...");
                                    Console.ReadKey();
                                    bQuitter = false;
                                    break;
                                case 'n':
                                    Console.Clear();
                                    Console.WriteLine("Au revoir!");
                                    bQuitter = true;
                                    break;
                                default:
                                    sSéquence = ""; // Remettre la séquence a zéro.
                                    iNbFoisTrouvé = 0; // Remettre le nombre de fois trouvé à zéro.
                                    Console.Clear();
                                    Console.WriteLine("ERREUR: Choix invalide!");
                                    Console.WriteLine("Le jeu va recommencer!");
                                    Console.WriteLine("APPUYER SUR UNE TOUCHE...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    AfficherCubes();
                                    Console.WriteLine("Appuyer sur une touche pour débuter...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    }
                }
            } while (!bQuitter);
        }
    }
}


