// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//2, 4 -> 16
//3, 5 -> 243 (3⁵)

double Numbers1(int numb1,int numb2)
{
       double summ = 1;
    {
      summ = Math.Pow(numb1,numb2);
    }
        return summ; 
}
Console.WriteLine("Введите число1: ");
int userNumb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int userNumb2 = Convert.ToInt32(Console.ReadLine());
double result = Numbers1(userNumb1,userNumb2);
Console.WriteLine($" Степень = {result}");

