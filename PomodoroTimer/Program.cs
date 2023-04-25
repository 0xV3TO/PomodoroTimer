namespace PomodoroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Configure session duration: ");
            int sessionMinutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Configure break duration: ");
            int breakMinutes = Convert.ToInt32(Console.ReadLine());

            Timer myTimer = new Timer(sessionMinutes, breakMinutes);
        }
    }
}