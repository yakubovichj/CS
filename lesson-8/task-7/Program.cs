//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue()
{
    return new Random().Next(0,10);
}
void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue();
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int m = GetNumberFromConsole("Введите размерность массива  m");
int n = GetNumberFromConsole("Введите размерность массива  n");
int[,] array = InitializateArray(m,n);

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[,] InitializateArray2(int n, int p)
{
    return new int[n,p];
}

int p = GetNumberFromConsole("Введите размерность массива  p");

int[,] array2 = InitializateArray2(n,p);

FillArray(array2);
PrintArray(array2);
Console.WriteLine();

int [,] result = new int[m,p];

void ProductMatrix(int[,] array, int [,] array2, int[,]result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < array.GetLength(0); k++)
                {
                    sum += array[i,k] * array2[k,j];
                }
                result[i,j] = sum;
        }

    }
}
ProductMatrix(array, array2, result);
PrintArray(result);