// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10 //9012 -> 12
int Numbers1(int numb)
{
       int summ = 0;
    while(numb > 0)
    {
     summ = summ + numb%10;
      numb = numb/10;
    }
        return summ; 
}
Console.WriteLine("Введите число: ");
int userNumb = Convert.ToInt32(Console.ReadLine());
int result = Numbers1(userNumb);
Console.WriteLine($"Сумма чисел в {userNumb} = {result}");

