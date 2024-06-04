using System.Formats.Asn1;

namespace MethodsExercise
{
    public class Program
    {
        
        public static void Add(int num1, int num2) 
        { 
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }

        public static void Multiply(int num1, int num2) 
        {
            int answer = num1 * num2;
            Console.WriteLine(answer);
        }

        public static void Divide(int num1, int num2) 
        {
            int answer = num1 / num2;
            Console.WriteLine(answer);
        }

        public static void Subtract(int num1, int num2) 
        {
            int answer = num1 - num2;
            Console.WriteLine(answer);
        }

        static void Main(string[] args)
        {
             
            Console.WriteLine("Hello - What is your first name?");   
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}.  What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color}  Is an awesome color!  What is your favirite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great!  Now what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}!  Here is your profile");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");

            Console.WriteLine();

            Add(10, 10);
            Subtract(10, 5);
            Multiply(2, 5);
            Divide(10, 2);

        }



    }
    
}
