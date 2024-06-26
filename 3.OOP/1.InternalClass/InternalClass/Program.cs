namespace InternalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;

            // A new Instance or Object for the class Car
            Car Audi = new Car("A3", "Audi", false);
            Car BMW = new Car("i7", "BMW", true);

            // Get
            Audi.Brand = Console.ReadLine();
            BMW.Brand = Console.ReadLine();

            // SET
            Console.WriteLine("Brand is: " + Audi.Brand + " and " + BMW.Brand);

            Console.ReadKey();
        }
    }
}
