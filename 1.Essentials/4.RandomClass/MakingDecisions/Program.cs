// Instance of the Random class
Random Random = new Random();

int randomNumber = Random.Next(1, 5);

string inputNumber = "2";

int num1 = 2;

if (int.TryParse(inputNumber, out num1))
{
    Console.WriteLine("It's a number");
    Console.WriteLine(num1 + randomNumber);
}
else {
    Console.WriteLine("It's not a number :(");
}

Console.ReadKey();
