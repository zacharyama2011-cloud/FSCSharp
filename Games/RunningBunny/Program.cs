namespace RunningBunny;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Press Enter/Return to run project");
        Console.ReadLine();
        
        using (new RunningBunnyGame().Run()) { }
    }
}