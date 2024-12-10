using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_Generic_Lists
{
    internal class Program
    {
        private static List<string> users = new List<string>();
        private static string user;
        private static int optie;
        private static bool isValidOption;

        static void Main(string[] args)
        {
            Console.WriteLine("1. Voeg een naam toe.");
            Console.WriteLine("2. Toon alle namen.");
            Console.WriteLine("3. Zoek een naam.");
            Console.WriteLine("4. Verwijder een naam.");
            Console.WriteLine("5. Toon het aantal namen.");
            Console.WriteLine("6. Stoppen.");

            do
            {
                do
                {
                Console.WriteLine("Kies een optie: ");
                isValidOption = int.TryParse(Console.ReadLine(), out optie);
                } while (!isValidOption);

                switch (optie)
                {
                    // Oefening 1
                    case 1:
                        AddUsersToList();
                        break;
                    // Oefening 2
                    case 2:
                        ShowAllNamesInList();
                        break;
                    // Oefening 3
                    case 3:
                        CheckIfNameIsInList();
                        break;
                    // Oefening 4
                    case 4:
                        DeleteNameFromList();
                        break;
                    // Oefening 5
                    case 5:
                        ShowAmountOfNamesInList();
                        break;
                    default:
                        Console.WriteLine("Choose a valid option from the menu.");
                        break;
                }
            } while (optie != 6);
        }
        
        // Oefening 1
        private static void AddUsersToList()
        {
            do
            {
                Console.Write("Geef een naam: ");
                user = Console.ReadLine();
            } while (String.IsNullOrEmpty(user));

            users.Add(user);
        }

        // Oefening 2
        private static void ShowAllNamesInList()
        {
            foreach (string name in users)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
        }

        // Oefening 3
        private static void CheckIfNameIsInList()
        {
        Console.Write("Geef een naam: ");
            string search = Console.ReadLine();

            if (users.IndexOf(search) != -1)
            {
                Console.WriteLine($"Gevonden op index: {users.IndexOf(search)}");
            } 
            else
            {
                Console.WriteLine("Naam niet gevonden in de lijst.");
            }
        }

        // Oefening 4
        private static void DeleteNameFromList()
        {
            string deleteName;
            do
            {
                Console.Write("Geef een naam om te verwijderen: ");
                deleteName = Console.ReadLine();
            } while (String.IsNullOrEmpty(deleteName));

            users.Remove(deleteName);
        }

        // Oefening 5
        private static void ShowAmountOfNamesInList()
        {
            Console.WriteLine($"Aantal namen in de lijst: {users.Count()}");
        }
    }
}
