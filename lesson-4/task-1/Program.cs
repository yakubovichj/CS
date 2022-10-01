
int GetNumberThreeDigit()
{
int num = 0;
while (num < 99 || num > 999)
{
Console.WriteLine("Enter three digit number ");
num = Convert.ToInt32(Console.ReadLine());
}
return num;

}

int a = GetNumberThreeDigit();
Console.WriteLine(a);