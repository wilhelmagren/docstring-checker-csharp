internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length != 1) {
            Console.Error.Write("You need to provide exactly one argument.");
            Environment.Exit(1);
        }

        string root = args[0];
        Console.Write("you want to search from " + root + " ?");

    }
}