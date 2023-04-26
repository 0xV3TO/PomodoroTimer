using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class Timer
    {
        public int sessionMinutes { get; set; }
        public int breakMinutes { get; set; }
        public int longBreak { get; set; }

        public Timer(int inputSessionMinutes, int inputBreakMinutes, int inputlongBreakMinutes)
        { 
            sessionMinutes = inputSessionMinutes;
            breakMinutes = inputBreakMinutes;
            longBreak = inputlongBreakMinutes;
        }
        public void Start()
        {
            int sessionNumber = 1;
          
            // TODO: do this 4 times (normal sessions) then add a large break
            for (int j = 0; j < 4; j++)
            {
                int seconds = 0;
                int minutes = 0;
                // TODO: improve the time format (MM:SS)
                for (int i = 0; i < sessionMinutes * 60; i++)
                {
                    Console.Clear();
                    string minutesFormat = string.Format("{0}{1}", '0', minutes);
                    string secondsFormat = string.Format("{0}{1}", '0', seconds);

                    if (minutes >= 10)
                    {
                        minutesFormat = $"{minutes}";
                    }
                    if (seconds >= 10)
                    {
                        secondsFormat = $"{seconds}";
                    }

                    string time = $"{minutesFormat}:{secondsFormat}";
                    Console.WriteLine("\tWorking Session {0}:\t{1}", sessionNumber, time);
                    seconds++;
                    if (seconds == 60)
                    {
                        minutes++;
                        seconds = 0;
                    }
                    Thread.Sleep(1000);
                }
                Console.Beep();
                sessionNumber++;
                minutes = 0;
                seconds = 0;
                // TODO: Add break loop
                for (int i = 0; i < breakMinutes * 60; i++)
                {
                    Console.Clear();
                    string minutesFormat = string.Format("{0}{1}", '0', minutes);
                    string secondsFormat = string.Format("{0}{1}", '0', seconds);

                    if (minutes >= 10)
                    {
                        minutesFormat = $"{minutes}";
                    }
                    if (seconds >= 10)
                    {
                        secondsFormat = $"{seconds}";
                    }

                    string time = $"{minutesFormat}:{secondsFormat}";
                    Console.WriteLine("\tNormal Break:\t\t{0}", time);
                    seconds++;
                    if (seconds == 60)
                    {
                        minutes++;
                        seconds = 0;
                    }
                    Thread.Sleep(1000);
                }
                Console.Beep();
            }
            int LongBreakSeconds = 0;
            int LongBreakMinutes = 0;

            for (int z = 0; z < longBreak * 60; z++)
            {
                Console.Clear();
                string minutesFormat = string.Format("{0}{1}", '0', LongBreakMinutes);
                string secondsFormat = string.Format("{0}{1}", '0', LongBreakSeconds);

                if (LongBreakMinutes >= 10)
                {
                    minutesFormat = $"{LongBreakMinutes}";
                }
                if (LongBreakSeconds >= 10)
                {
                    secondsFormat = $"{LongBreakSeconds}";
                }

                string time = $"{minutesFormat}:{secondsFormat}";
                Console.WriteLine("\tLong Break:\t\t{0}", time);
                LongBreakSeconds++;
                if (LongBreakSeconds == 60)
                {
                    LongBreakMinutes++;
                    LongBreakSeconds = 0;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
