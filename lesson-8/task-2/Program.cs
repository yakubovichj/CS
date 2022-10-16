//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int RowChangeColArray(int[,] arr)
{
    
    if(arr.GetLength(0) != arr.GetLength(0))
    {
        Console.WriteLine("Error. Impossible change row and columns");
    }
    else
    {
    int [,] result = new int[arr.GetLength(1),arr.GetLength(0)];

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           result[j,i]  = arr[i,j];  
        }
    }
    return result;   
    } 
}
int [,] arrayT =  RowChangeColArray(array);
Console.WriteLine(RowChangeColArray(arrayT));
