//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortStringArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
    
        {
            for(int k = 0; k < arr.GetLength(1)-1; k++)
        
            {
                if (arr[i,k] < arr[i, k + 1])
        
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i,k];
                    arr[i,k] = temp;
                }
            }
        }
    }           
}
SortStringArray(array);
PrintArray(array);
Console.WriteLine();
