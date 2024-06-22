// TEST

//for (int i = 0; i < 10; i++)
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("Hi mi name is:\r\n \t Tom and I'll be: " + i + "years old the next year");
//}

// ----------------------------------------------------------------
// Instance for Random class

//Random random = new Random();

//int numberGuess = random.Next(1, 20);
//int numberGuven = 0;
//int counter = 0;

//Console.WriteLine("Please enter the number to be gussed");

//while (numberGuess != numberGuven) {
//    counter++;
//    numberGuven = int.Parse(Console.ReadLine());

//    if (numberGuven < numberGuess)
//    {
//        Console.WriteLine("Too low, try again");
//    }
//    else if (numberGuven > numberGuess)
//    {
//        Console.WriteLine("Too high, try again");
//    }
//    else {
//        Console.WriteLine($"You've guessed, it took you {counter} times");
//    }
//}

//Console.ReadKey();


// ------------------------------------------------------------
// Loops Example - Switch case

//Console.WriteLine("Welcome to the adventure game");
//Console.WriteLine("Enter you character's name: ");
//string playerName = Console.ReadLine();

//Console.WriteLine("Select your character type: \r\n" +
//    "1. Warrior \r\n" +
//    "2. Wizard \r\n" +
//    "3. Archer");

//int characterType = int.Parse(Console.ReadLine());

//switch (characterType) {
//    case 1:
//        Console.WriteLine("Warrioor!!!");
//        break;
//    case 2:
//        Console.WriteLine("Wizaard!!!");
//        break;
//    case 3:
//        Console.WriteLine("Archeer!!!");
//        break;
//    default:
//        break;
//}

//Console.ReadKey();


// ---------------------------------------------------------
// Arrays - Foreach / For

//// Declare an Array
//int[] Hats = new int[5];

//// Set or assing values on our array
//for (int i = 0; i < Hats.Length; i++)
//{
//    Hats[i] = i + 2;
//}

//foreach (int item in Hats) { 
//    Console.WriteLine(item);
//}

//Console.ReadKey();


// -----------------------------------------------------------
// Multidemsional Arrays


//// Declaring the multidimensional array
//string[,] ticTacToe = new string[3, 3];

//for (int filas = 0; filas < 3; filas++){
//    for (int columnas = 0; columnas < 3; columnas++)
//    {
//        Console.WriteLine($"Enter X or O for the position: { filas } , {columnas}");
//        ticTacToe[filas, columnas] = Console.ReadLine();
//    }
//}

//foreach (var item in ticTacToe) {
//    Console.WriteLine(item);
//}

//Console.ReadKey();


// -----------------------------------------------------------
// 2. Multidimensioanl arrays

//int[] orderedList = { 5, 2, 1, 4, 8, 7, 3, 10 };

//orderedList = orderedList.Append(9).ToArray();

//// [0] [1] [2] [3]
//for (int i = 0; i < orderedList.Length - 1; i++)
//{
//    // [0] [1] [2] [3] = 4 ( The length for the Array is n-1 )
//    for (int j = 0; j < orderedList.Length - 1 - i; j++)
//    {
//        if (orderedList[j] > orderedList[j + 1])
//        {
//            // Intercambiar
//            int temp = orderedList[j];
//            orderedList[j] = orderedList[j + 1];
//            orderedList[j + 1] = temp;
//        }
//    }
//}

//// Imprimir los elementos de orderedlist2
//for (int i = 0; i < orderedList.Length; i++)
//{
//    Console.WriteLine(orderedList[i]);
//}

//Console.ReadKey();



// ---------------------------------------------------------
// Write a C# Sharp program to delete an element at the desired position from an array.


//int[] array = { 1, 2, 3, 4, 5 };

//int count = 0;

//foreach (int item in array) { 
//    Console.WriteLine($"Position [{count}] is: {item}");
//    count++;
//}

//Console.WriteLine("Type the number pisition desired to be deleted");
//int position = int.Parse(Console.ReadLine());

//int[] array2 = new int[array.Length];

//for (int i = 0; i < array2.Length; i++) {
//    if (i == position)
//    {
//        continue;
//    }
//    else {
//        array2[i] = array[i];
//        Console.WriteLine(array2[i]);
//    }
//}

//Console.ReadKey();


// ---------------------------------------------------------
// Write a C# Sharp program to find the second largest element in an array.

//int[] secLargestNumber = { 1006, 34, 352, 845, 330, 220 };

//int mayor = 0;
//int secMayor = 0;

//for (int i = 0; i < secLargestNumber.Length; i++)
//{
//    if (secLargestNumber[i] > mayor)
//    {
//        secMayor = mayor;
//        mayor = secLargestNumber[i];
//    }
//    else if (secLargestNumber[i] > secMayor && secLargestNumber[i] != mayor)
//    {
//        secMayor = secLargestNumber[i];
//    }
//}

//Console.WriteLine("Mayor: " + mayor);
//Console.WriteLine("Segundo Mayor: " + secMayor);
//Console.ReadKey();



// ----------------------------------------------------------------------------
// Write a C# Sharp program to find the second smallest element in an array.

//int[] secSmallest = { 23, 4, 5, 12 };

//int smallest = 9000;
//int nextSmallest = 9000;

//for (int i = 0; i < secSmallest.Length; i++)
//{
//    if (secSmallest[i] < smallest)
//    {
//        nextSmallest = smallest;
//        smallest = secSmallest[i];
//    }
//    else if (secSmallest[i] != smallest && secSmallest[i] < nextSmallest) {
//        nextSmallest = secSmallest[i];

//    }
//}

//Console.WriteLine($"Menor: {smallest}");
//Console.WriteLine($"Segundo Menor: {nextSmallest}");
//Console.ReadKey();


// ----------------------------------------------------------------------------
// Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.

//int[,] array2D = new int[3, 3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"Enter the value for the array position: {i}, {j}. ");
//        array2D[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//// [0, 0] [0, 1] [0, 2]
//// [1, 0] [1, 1] [1, 2]
//// [2, 0] [2, 1] [2, 2]

//int count = 0;

//foreach (var item in array2D)
//{
//    count++;
//    if (count == 4 || count == 7) {
//        Console.Write("\n");
//    }
//    Console.Write(item + " ");
//}

//Console.ReadKey();


// ----------------------------------------------------------------------------
// Write a C# Sharp program for adding two matrices of the same size.

//int[,] array1 = new int[2, 2];
//int[,] array2 = new int[2, 2];

//int[,] sumArrays = new int[2, 2];

//// FIRST MATRIX
//for (int fila = 0; fila < 2; fila++)
//{
//    for (int columna = 0; columna < 2; columna++) {
//        Console.Write($"Enter the value for the position [{fila}][{columna}] for the array 1: ");
//        array1[fila, columna] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine();

//// SECOND MATRIX
//for (int fila = 0; fila < 2; fila++)
//{
//    for (int columna = 0; columna < 2; columna++)
//    {
//        Console.Write($"Enter the value for the position [{fila}][{columna}] for the array 2: ");
//        array2[fila, columna] = int.Parse(Console.ReadLine());
//    }
//}

//// PRINT VALUES 1ST MATRIX
//Console.WriteLine("The values for the matrix 1 is: \n");
//for (int i = 0; i < 2; i++) {
//    for (int j = 0; j < 2; j++) {
//        Console.Write(array1[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//// PRINT VALUES 2ND MATRIX
//Console.WriteLine("The values for the matrix 2 is: \n");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(array2[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//// Print a new array with the evarage of two given arrays.
//// PRINT VALUES 3th MATRIX
//Console.WriteLine("The values for the matrix 3 is: \n");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        sumArrays[i, j] = array1[i, j] + array2[i, j];
//        Console.Write(sumArrays[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.ReadKey();




// ----------------------------------------------------------------------------
// Write a C# Sharp program to find the sum of the right diagonals of a matrix.

//Console.Write("Type the numbers of columns and rows for the matrix: ");
//int value = int.Parse(Console.ReadLine());

//Console.WriteLine();

//int[,] diagonals = new int[value, value];

//for (int i = 0; i < value; i++) {
//    for (int j = 0; j < value; j++) {
//        Console.Write($"Enter the value for the postion [{i}][{j}]: ");
//        diagonals[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine();

//int sum = 0;

//for (int i = 0; i < value; i++)
//{
//    for (int j = 0; j < value; j++)
//    {

//        Console.Write(diagonals[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//for (int i = 0; i < value; i++) {
//    for (int j = 0; j < value; j++) {

//        // ( i + j == value - 1 ) this condition finds the sum of the left diagonals
//        // ( i == j ) this condition finds the sum of the right diagonals
//        if (i == j) {
//            sum = sum + diagonals[i, j];
//        }
//    }    
//}

//Console.WriteLine($"The sum of the right diagonlas for the matrix {value} x {value}: {sum}");

//Console.ReadKey();

// [0,0][0,1][0,2]
// [1,0][1,1][1,2]
// [2,0][2,1][2,2]



// ----------------------------------------------------------------------------
// Write a C# Sharp program to find the sum of rows and columns in a matrix.


Console.Write("Enter the size for the array with format [x, x]: ");
int data = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arrayR_C = new int[data, data];

for (int i = 0; i < data; i++)
{
    for (int j = 0; j < data; j++)
    {
        Console.Write($"Enter the value for the position [{i}][{j}]: ");
        arrayR_C[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

int sumFila = 0;

for (int i = 0; i < data; i++)
{
    for (int j = 0; j < data; j++)
    {
        Console.Write(arrayR_C[i, j] + " ");
        sumFila = sumFila + arrayR_C[i, j];
    }
    Console.Write("- " + sumFila);
    sumFila = 0;
    Console.WriteLine();
}

Console.WriteLine();

int sumColumns = 0;

for (int i = 0; i < data; i++)
{
    for (int j = 0; j < data; j++)
    {
        sumColumns = sumColumns + arrayR_C[j, i];
    }
    Console.Write(sumColumns + " ");
    sumColumns = 0;
}

Console.ReadKey();
