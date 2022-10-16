//Написать рекурсивный метод деления одного числа на другое. Нужно получить остаток от деления и результат деления



int InputNumber (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}
int DivisionRemainder (int number, int divider)
{
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
 int number = InputNumber("Enter numerator; ");
 int divider = InputNumber("nter denominator: ");
 Console.WriteLine($"{number} /{ divider} = {DivisionFull(number, divider)}, division remainder {DivisionRemainder(number, divider)}");

