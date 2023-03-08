namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            //Exercise 1

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What country were you born in?");
            var country = Console.ReadLine();

            Console.WriteLine("What is the last concert you attended?");
            var band = Console.ReadLine();

            Console.WriteLine("Who is your favorite superhero?");
            var super = Console.ReadLine();

            string hello = $"Hey {name}, glad you came back! We have your favorite {color} scarf right where you left it." +
                           $"I heard you saw {super} at the {band} concert in {country}! Sounds like a great time!";
            Console.WriteLine(hello);
        }

        static void Main(string[] args)
        {
            MadLib();

            Console.WriteLine($"The sum is {Add(50, 43)}");
            Console.WriteLine($"The difference is {Subtract(54, 37)}");
            Console.WriteLine($"The product is {Multiply(9, 14)}");
            Console.WriteLine($"The quotient is {Divide(144, 12)}");
            Console.WriteLine($"The remainder is {Modulus(137, 6)}");

        }
        public static int Add(int num1, int num2)
        {
            var sum = num1 + num2;

            return sum;
        }
        public static int Subtract(int num1, int num2)
        {
            var diff = num1 - num2;

            return diff;
        }

        public static int Multiply(int num1, int num2)
        {
            var prod = num1 * num2;

            return prod;
        }
        public static int Divide(int num1, int num2)
        {
            var quo = num1 / num2;

            return quo;

        }
        public static int Modulus(int num1, int num2)
        {
            var rem = num1 % num2;

            return rem;
        }
    } }

