//vinoid InterNumber(out int A, out int B)
//{
  //  for (int i = 0; i < 2; i++)
    //{
      //  Console.WriteLine("Enter a number: ");
        //if (i == 0) A = Convert.ToInt32(Console.ReadLine());
        //if (i == 1) B = Convert.ToInt32(Console.ReadLine());
//    }
//}

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

int[] array = new int[8];

//int[] array = new int{1,0,10}; 
FillArray(array);
PrintArray(array);
Console.WriteLine();
