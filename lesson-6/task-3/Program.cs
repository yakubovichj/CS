
Console.WriteLine("Enter a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a >= b && a >= c) 
{
    max = a;
} 
else if (b >= a && b >= c)
{
    max = b;
} 
else if (c >= a && c >= b) 
{
    max = c;
} 
Console.WriteLine($"Max {max}");
if (((a+b+c) - max < max))
{
Console.WriteLine("Triangle exist");

}
else Console.WriteLine("Triangle  NOT exist");
