//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123


void FillArray(int[] arr) // Случайный ввод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200,201);
    }
}
void SearchArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >=10)
        count ++;
    }
    
    Console.WriteLine("Количество элементов массива от 10 до 99: " + count);
    
}



int [] array = new int [123];
FillArray(array);
SearchArray(array);