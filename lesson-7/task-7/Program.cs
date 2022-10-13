//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetNumberFromConsole(string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue()
{
    return new Random().Next(0, 10);
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetRandomValue();
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m, n];
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m, n);

FillArray(array);
PrintArray(array);
void CheckCoordinate()
{
    int a =  GetNumberFromConsole("Введите первую координату массива a");
    int b = GetNumberFromConsole("Введите вторую координату массива b");
    if (a < 0 || a >= m || b < 0 || b >= n)
    {
        Console.WriteLine("Координаты массива не существуют");
    }
    else
    {
        Console.WriteLine(array.GetValue(a, b));

    }


}
CheckCoordinate();