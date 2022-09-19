Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число являющееся квадратом первого");
int b = Convert.ToInt32(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("Это квадрат числа");
}
else 
{
    Console.WriteLine("Неверный ответ");
}