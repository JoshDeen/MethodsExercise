namespace MethodsExercise
{
    public class Program
    {
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

        }


    }
    
}
