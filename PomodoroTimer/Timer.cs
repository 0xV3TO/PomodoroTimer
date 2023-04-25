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
        public Timer(int inputSessionMinutes, int inputBreakMinutes) { }
    }
}
