//13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Enter a number  ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);

if (b.Length > 2)
{
    Console.WriteLine("The third digit in the number " + b[2]);
}
else
{
    Console.WriteLine("The third digit in the number is missing");
}
