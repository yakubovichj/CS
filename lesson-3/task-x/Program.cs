//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
long n = 2435345234; // 100000
// -> 9
// -> 123.456789 -> 123
// if (n < 100) {
//     Console.WriteLine("No 3d digit");
// } else {
//     double digits = Math.Ceiling(Math.Log10(n));
//     long digit3 = (n / (long) Math.Pow(10, digits - 3)) % 10;
//     Console.WriteLine(digit3);
// }

Console.WriteLine(n.ToString()[2]);