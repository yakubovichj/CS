// задайте двумерный массив. найдите сумму элементов главной диагоналт
// с индексами (0,0) (1,1) и тд
//задайте двумерный массив. найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты
// 1 4 7 2      1 4 7 2
// 5 9 2 3      5 81 2 9
// 8 4 2 4      8 4 2 4

// Задайте двумерный массив размера m x n, каждый элемент в массиве находится по формуле A = m+n
int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string StringArray2(int[,] array, string split) //преобразование массива в строку c заданным разделителем
{
    int length0 = array.GetLength(0); // получение длины массива
    int length1 = array.GetLength(1);
    string textarray = string.Empty; // обнуление строки
    for (int i = 0; i < length0; i++) //цикл со всеми элементами массива
    {
    for (int j = 0; j < length1; j++)
    
    {
    textarray += array[i,j]; //добавление в строку значение текущего элемента массива
    if (j == length1 - 1) //проверка является ли элемент последним
    
        textarray += split; //добавление разделителя между элементами в строку
    }
    textarray+="\n";
    }
    return textarray;// возврат значения элементов массива в в иде полученной строки

}

void FillArray(int[,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    
        for(int j = 0; j < array.GetLength(1); j++)
        
            array[i,j] = new Random().Next(min, max+1);
            
}


int DiagonalSum(int[,] array)
{
int sum = 0;
for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
        if(i == j)
            sum += array[i,j];
            
        return sum;
}

int m = InputNumber("Введите первую размерность массива ");
int n = InputNumber("Введите вторую размерность массива ");
int min = InputNumber("Введите минимальное значение случайных чисел ");
int max = InputNumber("Введите максимальное значение случайных чисел ");


int[,] array = new int[m,n];
FillArray(array, min, max);
Console.WriteLine(StringArray2(array, ", "));
Console.WriteLine();
Console.WriteLine($"Сумма элементов по диагонали: {DiagonalSum(array)}");