// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100 - 50;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0:0.00} ", arr[i]);
    }
    Console.WriteLine();
}

double FindMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max - min;
}

double[] massiv = new double[5];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Max Min dif: {0:0.00}", FindMinMax(massiv));