//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void ChangeString(int[,] arr)
{
    int temp; 
    for(int j = 0; j < arr.GetLength(1); j++)
        {
            temp = arr[0,j];
            arr[0,j] = arr[arr.GetLength(0)-1, j];
        }
    for(int j = 0; j < arr.GetLength(1); j++)
        {
            temp = arr[arr.GetLength(0)-1, j];
            arr[arr.GetLength(0)-1, j] = arr[arr.GetLength(0)-1, j];
        }
} 
ChangeString(array);
PrintArray(array);

