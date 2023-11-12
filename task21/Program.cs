/*21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
 в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Задайте координаты A x");
int userAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты A y");
int userAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты A z");
int userAz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты B x");
int userBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты B y");
int userBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты B z");
int userBz = Convert.ToInt32(Console.ReadLine());
double sqrX = Math.Pow(userBx - userAx, 2);
double sqrY = Math.Pow(userBy - userAy, 2);
double sqrZ = Math.Pow(userBz - userAz, 2);
double sqrt = Math.Sqrt(sqrX + sqrY + sqrZ);// выводит квадратный корень
Console.WriteLine(Math.Round(sqrt, 2));//округляет десятичное число