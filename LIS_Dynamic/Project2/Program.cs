using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading;

namespace Project2
{
    static class Program
    {
        static private int[,] c;
        static private List<int> numbers;
        static private List<int> selectedNumbers1 = new List<int>();
        static private List<int> selectedNumbers2 = new List<int>();
        static private int difference = 0;

        static void Main(string[] args)
        {
            SoundPlayer typewriter = new SoundPlayer();
            typewriter.SoundLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\audio.wav";
            typewriter.Play();
            Console.Title = "Kalghari Helper!";
            FirstPage();
            SecondPage();
            Console.ReadKey();
            typewriter.Stop();
            MainMenu();
            Console.ReadKey();
        }

        static void FirstPage()
        {
            int j = 1;
            for (int i = 1; i < 30; i++)
            {
                j += 5;
                Console.SetWindowSize(j, i);
                Thread.Sleep(20);
            }
            int timetick = 0;
            do
            {
                while (!Console.KeyAvailable)
                {
                    GenerateWelcome(timetick);
                    Thread.Sleep(180);
                    timetick++;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }

        static void GenerateWelcome(int i)
        {
            Console.Clear();
            Console.Write("\n\n");
            switch (i % 4)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    break;
            }
            Console.WriteLine("                   OO     OOOO     OO    OO OO OOO    OO             OOOOO         OOOOO        OOOO        OOOO     OO OO OOO");
            Console.WriteLine("                   OO    OO  OO    OO    OO           OO           OO           OO       OO    OO  OO      OO  OO    OO");
            Console.WriteLine("                   OO   OO    OO   OO    OO OO OOO    OO          OO           OO         OO   OO   OO    OO   OO    OO OO OOO");
            Console.WriteLine("                   OO  OO      OO  OO    OO           OO           OO           OO       OO    OO    OO  OO    OO    OO");
            Console.WriteLine("                    OOOO        OOOO     OO OO OOO    OO OO OOO      OOOOO         OOOOO       OO     OOOO     OO    OO OO OOO");
            Console.WriteLine("");
            switch (i % 4)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    break;
            }
            Console.WriteLine("                                                         OOOOOOOOOOOO       OOOOO");
            Console.WriteLine("                                                              OO         OO       OO");
            Console.WriteLine("                                                              OO        OO         OO");
            Console.WriteLine("                                                              OO         OO       OO");
            Console.WriteLine("                                                              OO            OOOOO");
            Console.WriteLine("");
            switch (i % 4)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.WriteLine("                          OO   OO         OO       OO            OOOOO        OO       OO        OO       OOOOOO     OO");
            Console.WriteLine("                          OO  OO        OO OO      OO          OO             OO       OO      OO OO      OO   OO    OO");
            Console.WriteLine("                          OOOOO        OOOOOOO     OO         OO     OOOOO    OO OO OO OO     OOOOOOO     OO OO      OO");
            Console.WriteLine("                          OO  OO      OO     OO    OO          OO      OO     OO       OO    OO     OO    OO   OO    OO");
            Console.WriteLine("                          OO   OO    OO       OO   OO OO OOO      OOOO        OO       OO   OO       OO   OO    OO   OO");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\tPress enter to continue...");
        }

        static void SecondPage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\tAli Abbasi\t9531503\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tAlgorithm Design\n");
            Console.WriteLine("\tProject2:");
            Console.WriteLine("\tUsing dynamic programming for king of the Kalghari!\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tDr. Rajayi");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tUniversity of Sistan and Baluchestan, Zahedan, Iran");
            Console.WriteLine("\t2018 December");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\tPress any key to continue...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.SetWindowSize(100, 30);
            Console.WriteLine("Plaese use up arrow, down arrow and enter key to control the menu.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bridge Problem");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Inheritance Problem");
            Console.WriteLine("Close");
            int i = 1;
            bool selectFlag = true;
            while (selectFlag)
            {
                ConsoleKey c;
                switch (c = Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow://key up
                        {
                            i--;
                            if (i <= 0)
                                i = 3;
                            MenuStyle(i);
                        }
                        break;
                    case ConsoleKey.DownArrow://key down
                        {
                            i++;
                            if (i >= 4)
                                i = 1;
                            MenuStyle(i);
                        }
                        break;
                    case ConsoleKey.Enter://key enter
                        {
                            StartFunction(i);
                            selectFlag = false;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid key entered!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        MenuStyle(i);
                        break;
                }
            }
        }

        static void MenuStyle(int i)
        {
            Console.Clear();
            if (i == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Plaese use up arrow, down arrow and enter key to control the menu.\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bridge Problem");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inheritance Problem");
                Console.WriteLine("Close");
            }
            if (i == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Plaese use up arrow, down arrow and enter key to control the menu.\n");
                Console.WriteLine("Bridge Problem");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Inheritance Problem");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Close");
            }
            if (i == 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Plaese use up arrow, down arrow and enter key to control the menu.\n");
                Console.WriteLine("Bridge Problem");
                Console.WriteLine("Inheritance Problem");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Close");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void StartFunction(int i)
        {
            Console.Clear();
            if (i == 1)
                BridgeProblemMainMenu();
            else if (i == 2)
                InheritanceProblemMainMenu();
            else
                Environment.Exit(0);
        }

        static void BridgeProblemMainMenu()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your numbers sequential and separated by dash(-):");
                string line = Console.ReadLine();
                string[] inputs = line.Split('-');
                var numbers = new List<int>();
                foreach (var num in inputs)
                    numbers.Add(Convert.ToInt32(num));
                var answer = BridgeProblem(numbers);
                Console.WriteLine("\nThe maximum number of possible buildable bridges is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}\n", answer.Count);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Buildable bridges:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Join(", ", answer));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nPress ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("any key");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" to enter another sequence of bridges, or press ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("ESC");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" to return to main menu.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            MainMenu();
        }

        static List<int> BridgeProblem(List<int> numbers)
        {
            var longestOne = new Dictionary<int, List<int>>();
            longestOne[0] = new List<int> { numbers[0] };

            for (var i = 1; i < numbers.Count; i++)
            {
                longestOne[i] = new List<int>();
                for (var j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && longestOne[i].Count < longestOne[j].Count + 1)
                        longestOne[i] = longestOne[j].Clone();
                }
                longestOne[i].Add(numbers[i]);
            }
            var maxIndex = 0;
            for (var i = 0; i < longestOne.Count; i++)
                if (longestOne[i].Count > maxIndex)
                    maxIndex = i;
            return longestOne[maxIndex];
        }

        public static List<int> Clone(this List<int> listToClone)
        {
            var array = new int[listToClone.Count];
            listToClone.CopyTo(array);
            return array.ToList();
        }

        static void InheritanceProblemMainMenu()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your objects values sequential and separated by dash(-):");
                string line = Console.ReadLine();
                string[] inputs = line.Split('-');
                numbers = new List<int>();
                foreach (var num in inputs)
                    numbers.Add(Convert.ToInt32(num));
                selectedNumbers1.Clear();
                selectedNumbers2.Clear();
                InheritanceProblem(numbers);
                Console.Write($"\nYou can devide your inheritance fair enough with a diffrence of ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{difference} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("by deviding objects, as follows:\n");
                Console.WriteLine("For your first son:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Join(", ", selectedNumbers1));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("For your second son:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Join(", ", selectedNumbers2));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nPress ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("any key");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" to enter another sequence of objects prices, or press ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("ESC");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" to return to main menu.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            MainMenu();
        }

        static void InheritanceProblem(List<int> numbers)
        {
            int total = numbers.Sum() / 2;
            c = new int[numbers.Count + 1, total + 1];
            Knapsack(numbers, total);
            var mediator = numbers.ToList();
            foreach (var temp in selectedNumbers1)
                mediator.Remove(temp);
            selectedNumbers2 = mediator.ToList();
            int sumOfGroup1 = selectedNumbers1.Sum();
            int sumOfGroup2 = selectedNumbers2.Sum();
            difference = sumOfGroup1 > sumOfGroup2 ? sumOfGroup1 - sumOfGroup2 : sumOfGroup2 - sumOfGroup1;
        }

        static void Knapsack(List<int> numbers, int total)
        {
            for (int j = 1; j <= total; j++)
                c[1, j] = 0;
            c[1, numbers[0]] = 1;
            for (int i = 2; i <= numbers.Count; i++)
            {
                for (int j = 1; j <= total; j++)
                {
                    c[i, j] = c[i - 1, j];
                    if (c[i, j] == 0)
                    {
                        if (j == numbers[i - 1])
                            c[i, j] = i;
                        else if (j > numbers[i - 1] && c[i - 1, j - numbers[i - 1]] != 0)
                            c[i, j] = i;
                    }
                }
            }
            //PrintDynamicProgrammingMatrix(numbers.Count, total);
            FindSelectedNumbers(numbers.Count, total);
        }

        public static void FindSelectedNumbers(int i, int j)
        {
            if (j > 0)
            {
                if (c[i, j] == i)
                {
                    selectedNumbers1.Add(numbers[i - 1]);
                    FindSelectedNumbers(i - 1, j - numbers[i - 1]);
                }
                else
                    FindSelectedNumbers(i - 1, j);
            }
        }

        public static void PrintDynamicProgrammingMatrix(int row, int column)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    Console.Write("{0}  ", c[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
