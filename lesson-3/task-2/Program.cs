double GetNumber(string name)
{
    Console.WriteLine("Enter the coordinate  " + name);
    return Convert.ToDouble(Console.ReadLine());
}
int GetNumChetv( double x, double y)
{
if (x > 0 && y > 0)
return 1;
else
if (x < 0 && y > 0)
return 2;
else
if (x < 0 && y < 0)
return 3;
else return 4;

}

double x = GetNumber("x");
double y = GetNumber("y");
Console.WriteLine("Quarter  "+ GetNumChetv(x,y));