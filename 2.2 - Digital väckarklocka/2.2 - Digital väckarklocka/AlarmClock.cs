using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2___Digital_väckarklocka
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Alarmtimmen är inte i intervallet 0-23.");
                    Console.ResetColor();
                }

                if ((value >= 0) && (value <= 23))
                {
                    _alarmHour = value;
                }
            }
        }
        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Alarmminuten är inte i intervallet 0-59.");
                    Console.ResetColor();
                }

                if ((value >= 0) && (value <= 59))
                {
                    _alarmMinute = value;
                }
            }
        }
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Timmen är inte i intervallet 0-23.");
                    Console.ResetColor();
                }

                if ((value >= 0) && (value <= 23))
                {
                    _hour = value;
                }
            }
        }
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Minuten är inte i intervallet 0-59.");
                    Console.ResetColor();
                }

                if ((value >= 0) && (value <= 59))
                {
                    _minute = value;
                }
            }
        }

        public AlarmClock()
        {
           
        }
        public AlarmClock(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }
        public bool TickTock()
        {
                if (Minute != 59)
                {
                    Minute++;
                }
                else
                {
                    Minute = 0;
                    if (Hour != 23)
                    {
                        Hour++;
                    }
                    else
                    {
                        Hour = 0;
                    }
                }

                if (Hour == AlarmHour && Minute == AlarmMinute)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public string ToString()
        {
            return "Hej";
        }
    }
}
