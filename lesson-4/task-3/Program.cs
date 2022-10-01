int InputNumber()
{
    Console.Write("Enter a number ");
    return Convert.ToInt32(Console.ReadLine());
}
int GetDigCount(int Number)
{
    int DigCount = 0;
    
    while(Math.Abs(Number)>0)
    {
        Number = Number / 10;
        DigCount++;
    }
    return DigCount;
}
Console.WriteLine("Amount of digits " + GetDigCount(InputNumber()));

