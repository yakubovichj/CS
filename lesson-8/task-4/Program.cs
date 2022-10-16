//Написать рекурсивный метод деления одного числа на другое. Нужно получить остаток от деления и результат деления


int countSets = 0;
(int, int, int) InputNumber (string text)
{

    Console.Write(text);
    return (Convert.ToInt32(Console.ReadLine()),
            Convert.ToInt32(Console.ReadLine()),
            Convert.ToInt32(Console.ReadLine()));

}
int DivisionRemainder (int number, int divider)
{
    countSets++;
    if (number >= divider)
    {
        number -= divider;
        return DivisionRemainder(number, divider);
    }
    else
        return number;
}

int DivisionFull(int number, int divider)
{
    if (number >= divider)
    {
        
        number -= divider;
        return DivisionFull(number, divider) + 1;
    }
    else
        return 0;
}
 var number = InputNumber("Enter numerator; ");
 Console.WriteLine(number.Item1);
//  int divider = InputNumber("Enter denominator: ");
//  Console.WriteLine($"{number} /{ divider} = {DivisionFull(number, divider)}, division remainder {DivisionRemainder(number, divider)}");
// Console.WriteLine($"Times pass: {countSets}");

