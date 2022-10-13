// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int GetNumberFromConsole(string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(-50, 50);
        }
    }
}

void PrintArray(double[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
}

void PrintArray2(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
    
            Console.Write("{0} ", arr[i,j]);
        }
        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = new int[m,n];

FillArray(array);
PrintArray2(array);


double [] MeanSum(int[,] arr)
{

   double [] sum = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
            sum[j] += array[i, j];
        }
        sum[j] /= m;
            
    }
    return sum;
}

Console.WriteLine("Result: ");
PrintArray(MeanSum(array));
