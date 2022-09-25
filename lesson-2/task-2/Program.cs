int CreateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int MaxDigit(int number)
{
    int Sotni = number / 100;
    int Dec = number / 10;
    int Ed = number % 10;
    return Sotni * 10 + Ed;
}

int a = CreateNumber();
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));
