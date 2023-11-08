// показать третью цифру заданного числа, или сообщить, что третьей цифры нет


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 
 
 int thirdDigit = (int)(number / Math.Pow(10, (int)Math.Log10(number) - 2)) % 10;

Console.WriteLine(thirdDigit);

if(number < 100)
Console.WriteLine("третьей цифры нет");
