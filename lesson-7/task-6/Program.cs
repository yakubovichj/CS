//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Задайте двумерный массив размером m x n, заполненный случайными целыми числами
// m=3 n=4
int GetNumberFromConsole(string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * 100 - 50;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write("{0:0.00} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);

