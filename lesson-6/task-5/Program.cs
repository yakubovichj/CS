


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
for (int i = arr.Length - 1; i >=0; i--)
{
arr[i] = a % 2;
a /=2;
}

PrintArray(arr);

