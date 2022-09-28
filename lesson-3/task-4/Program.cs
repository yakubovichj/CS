int GetNumber()
{
    Console.WriteLine("Enter the number  ");
    return Convert.ToInt32(Console.ReadLine());
}

void  GetPrintPow(int number)
{
    int count = 1;
    Console.WriteLine("Table of squares " + number + ": ");
    while (count <= number)
    {
        Console.Write("  " + Math.Pow(count,2) + " ");
        count ++;
    }
}
GetPrintPow(GetNumber());