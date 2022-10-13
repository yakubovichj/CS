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

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
            Console.Write(array[i,j]);
        }
    }
Console.WriteLine();
}
int m = InputNumber("Введите первую размерность массива ");
int n = InputNumber("Введите вторую размерность массива ");

int[,] array = new int[m,n];
FillArray(array);

Console.WriteLine(StringArray2(array, ", "));