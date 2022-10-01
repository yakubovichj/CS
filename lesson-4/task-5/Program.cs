// произведение от 1 до N
int GetNumber()
{
    Console.Write("Enter a number ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetProizv (int number)
{
    int proizv = 1;
    for (int i = 1; i <= number; i++)
    {
     proizv = proizv * i;  
    }
    return proizv;
}
int num = GetNumber();
Console.WriteLine("The multiplication of digits " + GetProizv (num));