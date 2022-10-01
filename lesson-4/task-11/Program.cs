//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetNumber()
{
    Console.Write("Enter a number ");
    return Convert.ToInt32(Console.ReadLine());
}
int A = GetNumber();
int B = GetNumber();
int result = 1;
while (B-- > 0)
{
    result *= A;
}
Console.WriteLine("A ^ B: {0}", result);
