//10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\
Console.Write("Enter a three digit number  ");

int a = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int a)
{
    return (a / 10) % 10;
}

Console.WriteLine(SecondDigit(a));
