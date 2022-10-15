namespace MethodsExercise
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($" {userName}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{userName}, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{userName}, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{userName}'s favorite color is {color}, " +
                $"favorite animal is a {animal}, and favorite band is {band}.");
        }
    }
}