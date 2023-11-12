// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

Console.WriteLine("Введите пятизначное число: ");
string numbers = Console.ReadLine();
     if(numbers[0] == numbers[4] && numbers[1] == numbers[3])
 { Console.WriteLine("да"); }
     else
 { Console.WriteLine("нет"); }


