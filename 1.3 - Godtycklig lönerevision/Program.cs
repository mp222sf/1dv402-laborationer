using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_1._3_NY
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = ReadInt("Ange antal löner att mata in: ");

            ProcessSalaries(count);

        }

        private static void ProcessSalaries(int count)
        {
            for (int col_1 = 0; col_1 <= 1 && col_1 >= 0; col_1++)
            {
                if (count == 1)
                {
                    // Ger felmeddelande om "Antal löner..." har värdet 1.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Du angav endast 1 lön. Minimum är 2.");

                    // Vid ESC avslutas loopen.
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tryck tagent för att fortsätta - ESC avslutar");
                    Console.ResetColor();
                    ConsoleKeyInfo inläsning_konsol_knapp;

                    inläsning_konsol_knapp = Console.ReadKey();
                    Console.WriteLine();

                    if (inläsning_konsol_knapp.Key != ConsoleKey.Escape)
                    {
                        count = ReadInt("Ange antal löner att mata in: ");
                    }
                    else
                    {
                        break;
                    }
                }
                
                // Om "Antal löner..." har ett värde större än 1, börjar programmet läsa in löner.
                if (count > 1)
                { 
                    // Skapa arrayer
                    int[] löner = new int[count];
                    int[] löner_kopia = new int[count];

                    for (int col_2 = 0; col_2 < count; col_2++)
                    {
                        löner[col_2] = ReadInt(String.Format("Ange lön nummer {0}: ", col_2 + 1));
                        löner_kopia[col_2] = löner[col_2];
                    }

                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------");


                    // Sorterar Array.
                    Array.Sort(löner);
                    double löner_median;

                    // Räknar median, medelvärde och lönespridning.
                    if (löner.Length % 2 == 0)
                    {
                        löner_median = Convert.ToDouble(löner[löner.Length / 2 - 1] + löner[(löner.Length / 2)]);
                        löner_median = Convert.ToDouble(löner_median / 2 + 0.5);
                        Console.WriteLine("{0,-27} {1} {2,15:c0}", "Medianlön", ":", (int)löner_median);
                    }
                    else
                    {
                        löner_median = löner.Length / 2;
                        Console.WriteLine("{0,-27} {1} {2,15:c0}", "Medianlön", ":", löner[(int)löner_median]);
                    }

                    // Räknar medelvärde och lönespridning.
                    Console.WriteLine("{0,-27} {1} {2,15:c0}", "Medellön", ":", (int)(löner.Average() + 0.5));
                    Console.WriteLine("{0,-27} {1} {2,15:c0}", "Lönespridning", ":", (int)(löner[löner.Length - 1] - löner[0]));
                    Console.WriteLine("----------------------------------------------");

                    // Skriver ut talen i Arrayen.
                    for (int col_3 = 0; col_3 <= count - 1; col_3++)
                    {
                        Console.Write(String.Format("{0,10}", löner_kopia[col_3]));

                        if (col_3 % 3 == 2)
                        {
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    // Avslutar programmet om ESC trycks in. Annars börjar det om från början.
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tryck tagent för att fortsätta - ESC avslutar");
                    Console.ResetColor();
                    ConsoleKeyInfo inläsning_konsol_knapp;

                    inläsning_konsol_knapp = Console.ReadKey();
                    Console.WriteLine();

                    if (inläsning_konsol_knapp.Key != ConsoleKey.Escape)
                    {
                        col_1--;
                        count = ReadInt("Ange antal löner att mata in: ");
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static int ReadInt(string prompt)
        {
            string input;
            int löner_input = 0;
            int while_col = 0;

            while (while_col < 1)
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                try
                {
                    löner_input = int.Parse(input);

                    if (löner_input > 2000000000)
                    {
                        throw new OverflowException();
                    }

                    if (löner_input <= 0)
                    {
                        throw new ArgumentNullException();
                    }
                    while_col++;
                }

                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Talet du angivit är för stort.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format! Det du angivit är inte ett heltal.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                catch (ArgumentNullException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Talet du har angivit är ett för litet tal (0 eller negativt tal).");
                    Console.WriteLine();
                    Console.ResetColor();   
                }
            }

            return löner_input;
        }
    }
}
