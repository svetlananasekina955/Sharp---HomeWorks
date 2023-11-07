// Найти максимальное из трех чисел.
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int c =  Convert.ToInt32(Console.ReadLine());
    
     int result = a;
       if(b >result)
        result = b;
        
          if(c > result)
          result = c;
          
         Console.WriteLine($"Наибольшее число из трех {result}");
         
  
  