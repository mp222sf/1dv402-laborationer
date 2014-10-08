using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2___Digital_väckarklocka
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test 1.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 1.\nTest av standardkonstruktorn.\n");
            Console.ResetColor();
            AlarmClock test1 = new AlarmClock();
            Console.WriteLine("{0:00}:{1:00} ({2:00}:{3:00})\n", test1.Hour, test1.Minute, test1.AlarmHour, test1.AlarmMinute);

            // Test 2.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 2.\nTest av konstruktorn med två parametrar, (9, 42).\n");
            Console.ResetColor();
            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine("{0:00}:{1:00}", test2.Hour, test2.Minute);

            // Test 3.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 3.\nTest av konstruktorn med fyra parametrar, (13, 24, 7, 35).\n");
            Console.ResetColor();
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("{0:00}:{1:00} ({2:00}:{3:00})", test3.Hour, test3.Minute, test3.AlarmHour, test3.AlarmMinute);

            // Test 4.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 4.\nStäller befintligt AlarmClock-objet till 23:58 och låter den gå 13 minuter.\n");
            Console.ResetColor();
            test3.Hour = 23;
            test3.Minute = 58;
            for (int i = 0; i < 13; i++)
            {
                test3.TickTock();
                Console.WriteLine("{0,5:00}:{1:00} ({2:00}:{3:00})", test3.Hour, test3.Minute, test3.AlarmHour, test3.AlarmMinute);
            }

            // Test 5.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 5.\nStäller befintligt AlarmClock-objekt till tiden 06:12 och alarmtiden till 06:15 och låter den gå 6 minuter.\n");
            Console.ResetColor();
            test3.Hour = 6;
            test3.Minute = 12;
            test3.AlarmHour = 6;
            test3.AlarmMinute = 15;

            for (int i = 0; i < 6; i++)
            {
                if (test3.TickTock())
                {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ♫ {0:00}:{1:00} ({2:00}:{3:00})     BEEP! BEEP! BEEP! BEEP! BEEP!", test3.Hour, test3.Minute, test3.AlarmHour, test3.AlarmMinute);
                Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("{0,5:00}:{1:00} ({2:00}:{3:00})", test3.Hour, test3.Minute, test3.AlarmHour, test3.AlarmMinute);
                }
                

            }

            // Test 6.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 6.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.\n");
            Console.ResetColor();
            test3.Hour = 55;
            test3.Minute = 70;
            test3.AlarmHour = -23;
            test3.AlarmMinute = -23;

            // Test 7.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("═══════════════════════════════════════════════════════════\nTest 7.\nTestar konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.\n");
            Console.ResetColor();
            AlarmClock test7 = new AlarmClock(55, 70, -23, -23);
        }
    }
}
