//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int SumLineElements(int[,] arr, int i)
{
    int sumLine = arr[i,0];
    for(int j = 1; j < arr.GetLength(1); j++)
    {
        sumLine +=arr[i,j];
    }
    return sumLine;

}

int  minSumLine = 0;
int sumLine = SumLineElements(array,0);
for(int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array,i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов {sumLine}");
