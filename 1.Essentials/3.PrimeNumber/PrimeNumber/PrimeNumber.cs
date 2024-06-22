Console.WriteLine("Type the amount of fibonacci numbers to be showed: ");
int numFibonacci, f3;
int f1 = 0;
int f2 = 1;

numFibonacci = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= numFibonacci; i++)
{
    f3 = f1 + f2
    Console.WriteLine(f3);
    f1 = f2
    f2 = f3
}
Console.ReadKey();



//Console.WriteLine("Type a number: ");
//int number;

//number = Convert.ToInt32(Console.ReadLine());

//int count = 0;

//for (int i = 1; i <= number; i++) {
     
//    if (number % i == 0){
//        count++;
//    }
//}

//if (count == 2){
//    Console.WriteLine("The entered number is a prime number");
//}
//else
//{
//    Console.WriteLine("The entered number is not a prime number");
//}

//Console.WriteLine("The amount of prime numbers for the given number is: " + count);
//Console.ReadKey();