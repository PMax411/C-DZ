﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreatearrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void Printarray (int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
        
            
         
            
        
    }
      Console.Write("]");
}
int [] array  = CreatearrayRnd(12 , -9 , 9);
Printarray(array);
Console.WriteLine();

void Inversearray (int[] arr) {
   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*= -1;
    
        
            
         
            
        
    }
}
Inversearray(array);
Printarray(array);


     

