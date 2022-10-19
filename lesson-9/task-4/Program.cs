// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int GetNumberFromConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbersConverse(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        WriteNumbersConverse(n - 1);
    }
}
WriteNumbersConverse(GetNumberFromConsole());