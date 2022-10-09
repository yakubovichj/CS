// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Enter number{i + 1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        
    }
}
void CheckArray(int[] arr)
{
    
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] > 0)
       {
        count++;
       } 
    }
    Console.WriteLine(count);
}


int[] array = new int[5];
FillArray(array);
CheckArray(array);
