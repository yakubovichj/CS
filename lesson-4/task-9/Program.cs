//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GetNumber()
{
    Console.Write("Enter a number ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
     sum = sum + i;  
    }
    return sum;
}
int num = GetNumber();
Console.WriteLine("The sum of digits " + GetSum (num));