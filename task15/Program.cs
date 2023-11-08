//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
 if(day == 6)
 Console.WriteLine("выходной");
 if(day == 7)
Console.WriteLine("Выходной");
else
Console.WriteLine("рабочий");