// 29. Напишите программу , которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33] 


 int[] GetRnd(int size, int minVal, int maxVal)
{
int[] array = new int[size];

 for(int i = 0; i < size; i++)
  {
  array[i] = new Random().Next(minVal,maxVal);
}
    return array;
}
 void PrintArray(int[] arr)
 {
for(int i = 0; i < arr.Length; i++)
{
System.Console.Write(arr[i] + " ");
}
 }
int[] userArray = GetRnd(8,0,10);
PrintArray(userArray);
