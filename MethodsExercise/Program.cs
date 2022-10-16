namespace MethodsExercise
{
    internal class Program
    {
        public static int Sum(params int[] list)
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {

            //----------------------Exercise 1--------------------------------

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($" {userName}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{userName}, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{userName}, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"There once was a person named {userName}. " +
                $"They loved to dream of a {color} {animal} while listening to {band}.");


            //----------------------Exercise 2--------------------------------

            var amountOfCars = Sum(6, 2);
            Console.WriteLine($"The amount of cars is: {amountOfCars}");

            var amountOfBikes = Subtract(6, 2);
            Console.WriteLine($"The amount of bikes is: {amountOfBikes}");

            var amountOfTrucks = Multiply(10, 2);
            Console.WriteLine($"The amount of trucks is: {amountOfTrucks}");

            var amountOfMopeds = Divide(125, 5);
            Console.WriteLine($"The amount of mopeds is: {amountOfMopeds}");

            var amountOfMotorcycles = Modulus(125, 6);
            Console.WriteLine($"The amount of mopeds is: {amountOfMotorcycles}");
        }
    }
}