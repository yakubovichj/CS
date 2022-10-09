// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// int[]SwapArray(int[] arr)
// {
//     int[] tempArr = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
        
//          tempArr[arr.Length -1  - i] = arr[i]; 
        
//     }
//     return tempArr;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }



// Console.WriteLine("Enter a number ");
// int n = Convert.ToInt32(Console.ReadLine());
// int index = 0;
//     while (n > 0)
//     {
//         n = n / 2;
//         index ++;
//     }
//     Console.WriteLine(index);
    
//     int[] bit = new int[index];
//     for (int i = 0; i < index; i++)
//      {
//         if (n % 2 == 0)
//     {
//         bit[i] = 0;
//     }
//     else
//     {
//         bit[i] = 1;
//     }
//      }

// PrintArray(bit);    
// SwapArray(bit);
// PrintArray(bit);


void SwapArrayTwo(int[] arr)
{
   int swap;
   for (int i = 0; i < arr.Length/2; i++)
   {
    swap = arr[arr.Length - i - 1];
    arr[arr.Length - 1 - i] = arr[i];
    arr[i] = swap;
   }

}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int a = Convert.ToInt32(Console.ReadLine());
int temp = a;
int index = 0;
while (temp > 0)
{
    index++;
    temp /=2;
}

int [] arr = new int[index];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = a % 2;
a /=2;
}
SwapArrayTwo(arr);
PrintArray(arr);
