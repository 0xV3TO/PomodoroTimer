namespace PomodoroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Configure session duration: ");
                int sessionMinutes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Configure break duration: ");
                int breakMinutes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Configure long break duration: ");
                int longBreakMinutes = Convert.ToInt32(Console.ReadLine());

                Timer myTimer = new Timer(sessionMinutes, breakMinutes, longBreakMinutes);

                Console.Write("type 'start' to begin the counter: ");
                string start = Console.ReadLine();
                if (start == "start")
                {
                    myTimer.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }

        }
    }
}
