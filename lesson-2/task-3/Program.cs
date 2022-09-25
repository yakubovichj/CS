int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void Module(int a, int b)
{
    if (b % a == 0)
    {
        Console.WriteLine("First number multiple of the second");
    }
    else
    {
        Console.WriteLine("First number isn't multiple of the second");
        Console.WriteLine("The remainder of the devision  " + b % a);

    }
}

Module(a, b);




