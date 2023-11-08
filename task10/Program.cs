// Ввести трехзначное число, на выходе показать вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
 int result = number / 10;
 int result1 = result % 10;
 Console.WriteLine(result1);