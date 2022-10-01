int GetNumber()

{
    int num = 0;
    while (LengthNum(num)<=2)
    {
    Console.WriteLine("Enter number ");
    num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int LengthNum(int Number)
{
    int DigCount = 0;
    
    while(Math.Abs(Number)>0)
    {
        Number = Number / 10;
        DigCount++;
    }
    return DigCount;
}

int GetDigitFromNumber(int number, int index)
{
  int num = number /Convert.ToInt32(Math.Pow(10,LengthNum(number) - index))%10;
  return num;  
}


int num = GetNumber();
Console.WriteLine("Three digit of number " + GetDigitFromNumber(num, 3));