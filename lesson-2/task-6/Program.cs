// 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter a number of the day from 1 to 7  ");
int a = Convert.ToInt32(Console.ReadLine());

void Checktheday(int a)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("Weekend");
    }
    else if (a < 1 || a > 7)
    {
        Console.WriteLine("Error");
    }
    else
    {
        Console.WriteLine("Weekday");
    }
}

Checktheday(a);
