// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int GetNumberFromConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetNumberFromConsole();
int n = GetNumberFromConsole();


int sumTo(int n)
{
    if(n == m)
        return m;
    return n + sumTo(n-1);
}
Console.WriteLine(sumTo(n));

