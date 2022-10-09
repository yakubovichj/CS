//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
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
    int max = arr[0];
    int indexMax = 0;
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
       if (arr[i] > max)
       {
        max = arr[i];
        indexMax = i;
        sum = sum + arr[i];
       } 
    }
    Console.WriteLine(sum);
    Console.WriteLine(arr[indexMax]);
    sum = sum - arr[indexMax];
    Console.WriteLine(sum);
if (arr[indexMax] < sum)
{
Console.WriteLine("Triangle exist");
}
else Console.WriteLine("Triangle not exist");
}


int[] array = new int[3];
FillArray(array);
CheckArray(array);