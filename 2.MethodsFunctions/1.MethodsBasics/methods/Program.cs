namespace methods
{
    internal class Program
    {
        // Field variable - instnace variable
        static int value;
        static void Main(string[] args)
        {
            Console.WriteLine(suma(1, 2));
            Console.ReadKey();
        }

        // Methods outside the main method
        static int suma(int num1, int num2) { 
            value = num1 + num2;
            return value;
        }
    }
}
