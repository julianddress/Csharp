
Console.WriteLine("Type the amount of fibonacci numbers to be showed: ");
int numFibonacci, f3;
int f1 = 0;
int f2 = 1;

numFibonacci = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numFibonacci; i++)
{
    f3 = f1 + f2;
    Console.WriteLine(f3);
    f1 = f2;
    f2 = f3;
}
Console.ReadKey();
