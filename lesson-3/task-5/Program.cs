//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int GetNumber()
{
    Console.Write("Enter the number: ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetPrintPow(int number)
{    
    Console.WriteLine("Table of cubes from 1 to {0}: ", number);
    for (int count = 1; count <= number; count++)
    {
        Console.Write("  " + Math.Pow(count,3) + " ");
    }
    Console.WriteLine();
}
GetPrintPow(GetNumber());