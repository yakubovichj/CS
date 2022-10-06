// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
void FillArray(int[] arr) // Случайный ввод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,9);
    }
}
string StringArray(int[] array, string split) //преобразование массива в строку c заданным разделителем
{
    int length = array.Length; // получение длины массива
    string textarray = string.Empty; // обнуление строки
    for (int i = 0; i < length; i++)
    {
    textarray += array[i]; //добавление в строку значения текущего элемента массива
    if (i < length - 1) // проверка является ли элемент последним
    {
        textarray += split; //добавление разделителя между элементами в строку
    } 

    }
    return textarray; //возврат значения элементов массива в виде строки
}
int FindNumber(int[] arr, int find) // Поиск индекса элемента в массиве с заданным числом, если число не найдено возвращает -1
{
for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            return i;
        }
    }
    return - 1;
}

int [] array = new int [4];
FillArray(array);
Console.WriteLine("Случайно заполненный массив: [{0}]", StringArray(array, ", "));
int number = 0;
Console.Write("Введите число для поиска в массиве  ");
number = Convert.ToInt32(Console.ReadLine());
 if (FindNumber(array, number) < 0)
 {
Console.WriteLine("Число отсутствует в массиве {0}", number);
 }
 else
 {
    Console.WriteLine("Число присутствует  в массиве {0}", number);
 }

