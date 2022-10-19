// Задайте згачение N. Напишите программу, которая выводит все натуральные числа в промежутке от 1 до N
// N=5 1 2 3 4 5
double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}
void WriteNumbers(double lastNumber)
{

    int counter = 1;
    while(counter <= lastNumber)
    {
       if(counter + 1 <= lastNumber)
             Console.Write(counter + ",");
        else Console.Write(counter);
        counter++;
    }
}

string WriteNumbersRecursion(int startNumber,double lastNumber)
{
    if (startNumber <= lastNumber)
        return startNumber + "," + WriteNumbersRecursion(startNumber + 1, lastNumber);
    else
        return string.Empty;
}
Console.Write(WriteNumbersRecursion(1, GetNumberFromConsole()));
