void FillArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,2);
}
}

void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
} 
}


int[] array1 = new int[] {1,2,3,4};
int[] array2 = array1;
array1[0] = 5;

PrintArray(array1);

Console.WriteLine();
PrintArray(array2);

Console.WriteLine();