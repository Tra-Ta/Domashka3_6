// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Enter the address of the element ->");
int address1 = Convert.ToInt32(Console.ReadLine());
address1 -= 1;
int address2 = Convert.ToInt32(Console.ReadLine());
address2 -= 1;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

void OutputElement(int[,] matrix)
{
    if (address1 > matrix.GetLength(1) && address2 > matrix.GetLength(0)) Console.WriteLine("An element with this address was not found in this array");
    else Console.WriteLine((array2D[address1, address2]));
}

OutputElement(array2D);