using System;

namespace MethodsEx
{
    internal class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            var fullName = Console.ReadLine();

            Console.WriteLine($"Hey {fullName} What's your favorite color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine("What's your favorite Animal");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("What's your favorite band?");
            var faveBand = Console.ReadLine();

            Console.WriteLine($"One day, {fullName} was walking through the woods wearing a {faveColor} shirt. " +
                $"Suddenly, a {faveAnimal} appeared with an iPod. " +
                $"It was listening to {faveBand}. {fullName} was surprised it liked {faveBand}, too! ");
        }
        static void Main(string[] args)
        {
            //MadLib();

            Console.WriteLine(Add(6, 7));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
