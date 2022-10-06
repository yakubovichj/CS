void FillArray(int[] arr) // Случайный ввод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,9);
    }
}
string StringArray(int[] array, string split) //преобразование массива в строку c заданным разделителем
{
    int length = array.Length;
    string textarray = string.Empty;
    for (int i = 0; i < length; i++)
    {
    textarray += array[i];
    if (i < length - 1)
    {
        textarray += split;
    } 

    }
    return textarray;
}
void ChangeArray(int[] arr) // замена элементов массива
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] *= -1; 
}
}

int [] array = new int [4];
FillArray(array);
Console.WriteLine("Случайно заполненный массив: [{0}]", StringArray(array, ", "));
ChangeArray(array);
Console.WriteLine("Массив с заменой элементов: [{0}]",  StringArray(array, ", "));
