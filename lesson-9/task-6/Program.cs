// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int GetNumberFromConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetNumberFromConsole();
int n = GetNumberFromConsole();


int AckermanFunction(int m, int n) 
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
       return AckermanFunction(m - 1, 1); 
    }

    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    
}
Console.WriteLine(AckermanFunction(m, n));
    
