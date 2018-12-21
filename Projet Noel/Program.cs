using System;
using System.Globalization;//A rajouter pour faire appel à une librairie pour la commande (CultureInfo.CurrentCulture.TextInfo.ToTitleCase() pour que la premiere lettre de l'entrée utilisateur soit forcé en majuscule a la ligne 27
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Noel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nous allons jouer à mon jeux de Noël!");
            Console.WriteLine("Trouver les 3 bonnes réponses aux 3 questions pour obtenir votre Cadeau de Noël!");
            Console.WriteLine("Tapez \"Start\" pour commencer.");
            string userCommand;
            userCommand = Console.ReadLine();
            while (CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userCommand) != "Start")
            {
                Console.WriteLine("Tapez correctement \"Start\" sans les guillemets pour commencer à jouer.");
                userCommand = Console.ReadLine();
            } 
            Console.Clear();
            Console.WriteLine("Quel est la vraie couleur du Père Noël?");
            string userAnswer1 = Console.ReadLine();
            if (CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userAnswer1) != "Vert") // CF commentaire ligne 2
            {
                Console.WriteLine("Mauvaise réponse, essaie encore!");
                userAnswer1 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bonne réponse!");
            }
            System.Threading.Thread.Sleep(4000);//pause
            Console.Clear();
            Console.WriteLine("Encore 2 questions!");
            Console.WriteLine("Comment s'appelle l'animal qui tire le traineau du Père Noël?");
            string userAnswer2 = Console.ReadLine();
            if (CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userAnswer2) != "Renne")
            {
                Console.WriteLine("Mauvaise réponse, essaie encore!");
                userAnswer2 = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bonne réponse!");
            }
            System.Threading.Thread.Sleep(4000);//pause
            Console.Clear();
            Console.WriteLine("Plus qu'une bonne réponse à donner!");
            Console.WriteLine("Pain au chocolat ou Chocolatine? (Le Père Noël apprécie qu'on respecte les majuscules).");
            string userAnswer3;
            userAnswer3 = Console.ReadLine();
            while (userAnswer3 != "Pain au chocolat")
            {
                Console.WriteLine("Pas de cadeaux pour les Hérétiques!");
                userAnswer3 = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Bonne réponse!");
            Console.WriteLine("Oh Oh Oh, votre Cadeau arrive!");
            System.Threading.Thread.Sleep(6000);//pause
            Console.Clear();


            Console.WriteLine("Bravo! tu as mérité ce fabuleux cadeau!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("         *      ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("        /\\");
            Console.WriteLine("      /_  _\\");
            Console.WriteLine("     */    \\ *");
            Console.WriteLine("    /_      _\\");
            Console.WriteLine("   * /       \\ *");
            Console.WriteLine("   /           \\");
            Console.WriteLine(" /______   ______\\");
            Console.WriteLine("*       | |       * ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    Joyeux Noël");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
