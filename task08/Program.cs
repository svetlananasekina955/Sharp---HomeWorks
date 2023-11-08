// написать программу, которая выводит все четные числа от 1 до number , через знак табуляции
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
    
      for(int i = 2; i <= number; i+=2)
      System.Console.Write(i + "    ");
    
