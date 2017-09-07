using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charuder
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Menu: ");
            Console.WriteLine("-----");
            Console.WriteLine("[1] Play Charuder");
            Console.WriteLine("[2] Add new words");
            Console.WriteLine("[3] Quit");
            
        

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Play();
                    break;
                case 2:
                    AddNewWords();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Choose one of the alternatives in the menu!");
                    break;
            }
        }

        private static void AddNewWords()
        {
            
        }

        private static void Play()
        {
            //CreateTeams();

        }

        //private static void CreateTeams()
        //{
        //    Console.Write("How many teams are playing this awesome game? ");
        //    int nrOfTeams = int.Parse(Console.ReadLine()); // på nåt sätt kolla så man skriver en siffra!
        //    List < Team >
        //    for (int i = 0; i < nrOfTeams; i++)
        //    {
        //        Console.WriteLine($"Name of team {i}: ");
        //        Team team = new Team()
        //        List<Team>
        //    }
        //}
    }
}
