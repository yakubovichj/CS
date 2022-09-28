

        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int GetNumber()
{
    Console.WriteLine("Enter a five-digit number");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsPalindrom(int a)
{
    return a / 1000 % 10 == a / 10 % 10 && a / 10000 == a % 10;
}

int inputNumber = GetNumber();
bool answer = IsPalindrom(inputNumber);

Console.WriteLine(answer);
