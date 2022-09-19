Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a + "; min = " + b);
} 
else 
{
    Console.WriteLine("max = " + b + "; min = " + a);
}

Console.WriteLine();