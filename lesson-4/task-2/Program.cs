﻿int GetNumber()
{
    int num = 0;
    while (num<=1)
    {
    Console.WriteLine("Enter number A (more than 1)");
    num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}
int GetSum1toA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum +=i;
    }
    return sum;
}
int A = GetNumber();
Console.WriteLine("The Sum of the numbers from 1 to " + A +": "+ GetSum1toA(A));