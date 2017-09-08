using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;

namespace Charuder
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        static Random random = new Random();
        static List<Team> teamList = new List<Team>();
        static int counter = 0;

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
            Console.Clear();
            CreateTeams();
            CreateTimer();

        }

        private static void CreateTimer()
        {
            for (int i = 0; i < teamList.Count; i++)
            {

                Timer aTimer = new Timer();
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                aTimer.Interval = 10000;
                aTimer.Enabled = true;
                OnTimedEvent();
                while (Console.Read() != 'q');
                //Console.ReadLine();
                
            }
            
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.Clear();
            PrintTeam();
            CountDown();
            GetNewWord();
            
        }
        private static void OnTimedEvent()
        {
            Console.Clear();
            PrintTeam();
            CountDown();
            GetNewWord();
        }
        private static void PrintTeam()
        {
            Console.WriteLine($"{teamList[counter].Name}'s time to play!");
            counter++;
        }


        // skall ej kunna trycka ngn knapp under tiden countdown görs
        private static void CountDown()
        {
            Console.WriteLine("Countdown: ");
            for (int a = 5; a > 0; a--)
            {
                Console.WriteLine(a);
                System.Threading.Thread.Sleep(1000);
            }
            
        }

        private static void GetNewWord()
        {
            while (true)
            {
                int randomNr = random.Next(1, 10);

                Console.WriteLine(Connection.ReadWordFromDatabase("Substantiv", randomNr));
                Console.ReadLine();
            }
        }

        private static void CreateTeams()
        {
            Console.Write("How many teams are playing this awesome game? ");
            int nrOfTeams = int.Parse(Console.ReadLine()); // på nåt sätt kolla så man skriver en siffra!
            

            for (int i = 0; i < nrOfTeams; i++)
            {
                Console.WriteLine($"Name of team {i+1}: ");
                teamList.Add(new Team(Console.ReadLine()));
                
            }
            
        }
    }
}
